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

namespace SaleWinApps
{
	public partial class frmOrderDetails : Form
	{
		public frmOrderDetails()
		{
			InitializeComponent();
		}
		public bool InsertOrUpdate { get; set; }
		public OrderDetail orderDetailInfo { get; set; }
		public int OrderId { get; set; }

		IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
		IProductRepository productRepository = new ProductRepository();

		private void frmOrderDetails_Load(object sender, EventArgs e)
		{
			orderIdTextbox.Text = OrderId.ToString();
			orderIdTextbox.Enabled = false;
			priceTextbox.Enabled = false;
			unitPriceTextbox.Enabled = false;
			if (InsertOrUpdate) //Update mode
			{
				productIDTextbox.Enabled = false;
				orderIdTextbox.Text = orderDetailInfo.OrderId.ToString();
				productIDTextbox.Text = orderDetailInfo.ProductId.ToString();
				unitPriceTextbox.Text = productRepository.GetProductById(orderDetailInfo.ProductId).UnitPrice.ToString();
				priceTextbox.Text = (productRepository.GetProductById(orderDetailInfo.ProductId).UnitPrice * orderDetailInfo.Quantity) + "";
				quantityTextbox.Text = orderDetailInfo.Quantity.ToString();
				discountTextbox.Text = orderDetailInfo.Discount.ToString();
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void quantityTextbox_TextChanged(object sender, EventArgs e)
		{
			if (quantityTextbox.Text.Length == 0) priceTextbox.Text = "0";
			else
				priceTextbox.Text = (productRepository.GetProductById(int.Parse(productIDTextbox.Text)).UnitPrice
									* int.Parse(quantityTextbox.Text)) + "";
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			productIDTextbox.Enabled = true;
			orderIdTextbox.Text = OrderId.ToString();
			try
			{
				var orderDetail = new OrderDetail
				{
					OrderId = int.Parse(orderIdTextbox.Text),
					ProductId = int.Parse(productIDTextbox.Text),
					Quantity = int.Parse(quantityTextbox.Text),
					UnitPrice = decimal.Parse(priceTextbox.Text),
					Discount = double.Parse(discountTextbox.Text)
				};

				//if (InsertOrUpdate)
				//{
				//	orderDetailRepository.UpdateOrderDetail(orderDetail);
				//}
				//else
				//{
				orderDetailRepository.AddNewOrderDetail(orderDetail);
				MessageBox.Show("success");
				//}
				//this.DialogResult = DialogResult.OK;
				//this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}

		private void productIDTextbox_TextChanged(object sender, EventArgs e)
		{
			if (productIDTextbox.Text.Length == 0) { unitPriceTextbox.Text = ""; return; }
			Product product = productRepository.GetProductById(int.Parse(productIDTextbox.Text));
			if (product == null)
			{
				MessageBox.Show("Not found product");
				productIDTextbox.Text = "";
				return;
			}
			else
			{
				unitPriceTextbox.Text = product.UnitPrice.ToString();
			}
		}

		//private void deleteButton_Click(object sender, EventArgs e)
		//{
		//	orderDetailRepository.DeleteOrderDetail(int.Parse(orderIdTextbox.Text), int.Parse(productIDTextbox.Text));
		//	this.DialogResult = DialogResult.OK;
		//	this.Close();
		//}
	}
}
