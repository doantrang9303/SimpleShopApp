using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
	public partial class frmOrderDetail : Form
	{
		IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
		BindingSource source;
		public frmOrderDetail()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void ClearText()
		{
			txtOrderId.Text = string.Empty;
			txtProductId.Text = string.Empty;
			txtUnitPrice.Text = string.Empty;
			txtQuantity.Text = string.Empty;
			txtDiscount.Text = string.Empty;

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			displayData(orderDetailRepository.GetOrderDetails());
		}
		public void LoadOrderList()
		{
			var cars = orderDetailRepository.GetOrderDetails();
			try
			{
				source = new BindingSource();
				source.DataSource = cars;
				txtOrderId.DataBindings.Clear();
				txtProductId.DataBindings.Clear();
				txtUnitPrice.DataBindings.Clear();
				txtQuantity.DataBindings.Clear();
				txtDiscount.DataBindings.Clear();


				txtOrderId.DataBindings.Add("Text", source, "OrderId");
				txtProductId.DataBindings.Add("Text", source, "ProductId");
				txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
				txtQuantity.DataBindings.Add("Text", source, "Quantity");
				txtDiscount.DataBindings.Add("Text", source, "Discount");


				dgvOrderDetail.DataSource = null;
				dgvOrderDetail.DataSource = source;
				if (cars.Count() == 0)
				{
					ClearText();

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load order list");
			}
		}

		private void displayData(IEnumerable<OrderDetail> products)
		{
			if (products.Count() == 0) products = orderDetailRepository.GetOrderDetails();
			try
			{
				source = new BindingSource();
				source.DataSource = products;

				txtOrderId.DataBindings.Clear();
				txtProductId.DataBindings.Clear();
				txtUnitPrice.DataBindings.Clear();
				txtQuantity.DataBindings.Clear();
				txtDiscount.DataBindings.Clear();


				txtOrderId.DataBindings.Add("Text", source, "OrderId");
				txtProductId.DataBindings.Add("Text", source, "ProductId");
				txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
				txtQuantity.DataBindings.Add("Text", source, "Quantity");
				txtDiscount.DataBindings.Add("Text", source, "Discount");


				dgvOrderDetail.DataSource = null;
				dgvOrderDetail.DataSource = source;
				if (products.Count() == 0)
				{
					ClearText();
					btnDelete.Enabled = false;
				}
				else
				{
					btnDelete.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load product list");
			}
		}
		private void btnReturn_Click(object sender, EventArgs e)
		{
			try
			{
				var order = new OrderDetail
				{
					OrderId = int.Parse(txtOrderId.Text),
					ProductId = int.Parse(txtProductId.Text),
					UnitPrice = decimal.Parse(txtUnitPrice.Text),
					Quantity = int.Parse(txtQuantity.Text),
					Discount = float.Parse(txtDiscount.Text),
				};

				orderDetailRepository.UpdateOrderDetail(order);

				MessageBox.Show("Success");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void dgvOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{




			var products = orderDetailRepository.GetOrderDetails();
			displayData(products);
			//Focus on updated product


		}

		private void frmOrderDetail_Load(object sender, EventArgs e)
		{

			btnDelete.Enabled = false;
			btnLoad_Click(sender, e);
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private OrderDetail GetOrderDetailObject()
		{
			OrderDetail order = null;
			try
			{
				order = new OrderDetail
				{
					OrderId = int.Parse(txtOrderId.Text),
					ProductId = int.Parse(txtProductId.Text),
					UnitPrice = decimal.Parse(txtUnitPrice.Text),
					Quantity = int.Parse(txtQuantity.Text),
					Discount = float.Parse(txtDiscount.Text),
				};
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "Get order"); }
			return order;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				var order = GetOrderDetailObject();
				DialogResult result = MessageBox.Show("Do you want really to delete", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					orderDetailRepository.DeleteOrderDetail(order.OrderId, order.ProductId);
					LoadOrderList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void LoadOrder()
		{
			OrderDetail member = new OrderDetail();
			var order = orderDetailRepository.GetOrderDetails();

			try
			{
				foreach (var item in order)
				{

					//if (String.Compare(item.MemberName,txtSearch.Text,true)==0)
					if (item.ProductId.Equals(txtSearch.Text))
					{
						source = new BindingSource();
						source.DataSource = orderDetailRepository.GetOrderDetailByOrderId(item.OrderId);
						txtOrderId.DataBindings.Clear();
						txtProductId.DataBindings.Clear();
						txtUnitPrice.DataBindings.Clear();
						txtQuantity.DataBindings.Clear();
						txtDiscount.DataBindings.Clear();

						txtOrderId.DataBindings.Add("Text", source, "OrderId");
						txtProductId.DataBindings.Add("Text", source, "ProductId");
						txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
						txtQuantity.DataBindings.Add("Text", source, "Quantity");
						txtDiscount.DataBindings.Add("Text", source, "Discount");
						dgvOrderDetail.DataSource = null;
						dgvOrderDetail.DataSource = source;
						break;

					}
				}



			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadOrder();
		}

		private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (txtSearch.Text == null)
			{
				displayData(orderDetailRepository.GetOrderDetails());
				return;
			}
			if (searchComboBox.SelectedIndex == 0)
			{
				displayData(orderDetailRepository.GetOrderDetails());
			}
			else if (searchComboBox.SelectedIndex == 1)
			{
				_ = int.TryParse(txtSearch.Text, out int id);
				displayData(orderDetailRepository.GetOrderDetails().Where(mem => mem.OrderId == id));
			}
			else if (searchComboBox.SelectedIndex == 2)
			{
				_ = int.TryParse(txtSearch.Text, out int id);
				displayData(orderDetailRepository.GetOrderDetails().Where(mem => mem.ProductId == id));
			}
		}
	}
}
