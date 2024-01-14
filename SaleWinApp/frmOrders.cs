using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using SaleWinApps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaleWinApp
{
	public partial class frmOrders : Form
	{
		public IOrderRepository _orderRepository { get; set; }
		public bool InsertOrUpdate { get; set; }
		public BusinessObject.Order orderInfo { get; set; }

		IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

		BindingSource source;
		public frmOrders()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var order = new BusinessObject.Order
				{
					OrderId = int.Parse(txtOrderId.Text),
					MemberId = int.Parse(txtMemberId.Text),
					OrderDate = DateTime.Parse(txtOrderDate.Text),
					ShippedDate = txtShippedDate.Text.Equals("  /  /       :") ? null : global::System.DateTime.Parse(txtShippedDate.Text),
					RequiredDate = txtRequiredDate.Text.Equals("  /  /       :") ? null : global::System.DateTime.Parse(txtRequiredDate.Text),
					Freight = txtFreight.Text.Equals("") ? null : decimal.Parse(txtFreight.Text)
				};

				if (InsertOrUpdate)
				{
					_orderRepository.UpdateOrder(order);
				}
				else
				{
					_orderRepository.AddNewOrder(order);

				}
				MessageBox.Show("success");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, InsertOrUpdate ? "Error Update a order " : "Error Insert a new order");
			}
		}

		private void ClearText()
		{
			txtOrderId.Text = string.Empty;
			txtMemberId.Text = string.Empty;
			txtOrderDate.Text = string.Empty;
			txtRequiredDate.Text = string.Empty;
			txtShippedDate.Text = string.Empty;
			txtFreight.Text = string.Empty;

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{

		}

		private void txtOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			DataGridViewRow dataGridViewRow = dgvOrder.Rows[e.RowIndex];
			int orderID = (int)(dataGridViewRow.Cells["OrderId"].Value);
			int productID = (int)(dataGridViewRow.Cells["ProductId"].Value);

			OrderDetail orderDetail = orderDetailRepository.GetOrderDetailById(orderID, productID);
			if (orderID == 0) { newButton_Click(sender, e); return; };
			frmOrderDetails frmOrderDetail = new frmOrderDetails
			{
				Text = "Update a order detail",
				InsertOrUpdate = true,
				orderDetailInfo = orderDetail,
				OrderId = int.Parse(txtOrderId.Text)
			};

			int id = int.Parse(txtOrderId.Text);
			if (frmOrderDetail.ShowDialog() == DialogResult.OK)
			{
				displayData(orderDetailRepository.GetOrderDetailByOrderId(orderInfo.OrderId));
				//Focus on updated order
				source.Position = id - 1;
			}
		}

		private void frmOrder_Load(object sender, EventArgs e)
		{
			txtOrderId.Enabled = false;
			if (InsertOrUpdate) //Update mode
			{
				txtOrderId.Text = orderInfo.OrderId.ToString();
				txtMemberId.Text = orderInfo.MemberId.ToString();
				txtOrderDate.Text = FixDateFormat(orderInfo.OrderDate);
				txtShippedDate.Text = orderInfo.ShippedDate != null ? FixDateFormat(orderInfo.ShippedDate.GetValueOrDefault()) : null;
				txtRequiredDate.Text = orderInfo.RequiredDate != null ? FixDateFormat(orderInfo.RequiredDate.GetValueOrDefault()) : null;
				txtFreight.Text = orderInfo.Freight != null ? orderInfo.Freight.ToString() : null;
			}
			else
			{
				int lastIndex = _orderRepository.GetOrders().ToList().Last().OrderId;
				txtOrderId.Text = (lastIndex + 1).ToString();
			}
			if (orderInfo != null)
				displayData(orderDetailRepository.GetOrderDetailByOrderId(orderInfo.OrderId));
		}
		private string FixDateFormat(DateTime date)
		{
			if (date.Date.ToString().Length == 21)
			{
				return "0" + date.ToLocalTime();
			}
			return date.ToLocalTime().ToString();
		}
		private void displayData(IEnumerable<OrderDetail> orderdetails)
		{
			if (orderdetails.Count() == 0) MessageBox.Show("This order is empty");
			try
			{
				source = new BindingSource();
				source.DataSource = orderdetails;
				dgvOrder.DataSource = null;
				dgvOrder.DataSource = source;
				dgvOrder.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load orders list");
			}
		}

		private void newButton_Click(object sender, EventArgs e)
		{
			frmOrderDetails frmOrderDetail = new frmOrderDetails
			{
				Text = "Add a new order detail",
				InsertOrUpdate = false,
				OrderId = int.Parse(txtOrderId.Text)
			};

			int id = int.Parse(txtOrderId.Text);
			if (frmOrderDetail.ShowDialog() == DialogResult.OK)
			{
				displayData(orderDetailRepository.GetOrderDetailByOrderId(orderInfo.OrderId));
				//Focus on updated order
				source.Position = id - 1;
			}
		}

		private void newbutton_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmOrderDetails frmOrderDetails = new frmOrderDetails
			{
				Text = "Add a new order detail",
				InsertOrUpdate = false,
				OrderId = int.Parse(txtOrderId.Text)
			};

			int id = int.Parse(txtOrderId.Text);
			if (frmOrderDetails.ShowDialog() == DialogResult.OK)
			{
				displayData(orderDetailRepository.GetOrderDetailByOrderId(orderInfo.OrderId));
				//Focus on updated order
				source.Position = id - 1;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmOrderDetails frmOrderDetails = new frmOrderDetails
			{
				Text = "Add a new order detail",
				InsertOrUpdate = false,
				OrderId = int.Parse(txtOrderId.Text)
			};

			int id = int.Parse(txtOrderId.Text);
			if (frmOrderDetails.ShowDialog() == DialogResult.OK)
			{
				displayData(orderDetailRepository.GetOrderDetailByOrderId(orderInfo.OrderId));
				//Focus on updated order
				source.Position = id - 1;
			}

		}
	}
}
