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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaleWinApp
{
	public partial class frmOrder : Form
	{

		IOrderRepository orderRepository = new OrderRepository();
		BindingSource source;
		public frmOrder()
		{
			InitializeComponent();
		}


		private void dvgMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

			Order order = GetOrder();
			if (order.OrderId == 0) { newButton_Click(sender, e); return; };
			frmOrders frmOrderDetail = new frmOrders
			{
				Text = "Update a order",
				InsertOrUpdate = true,
				orderInfo = order,
				_orderRepository = orderRepository
			};

			int id = int.Parse(orderIDTextbox.Text);
			if (frmOrderDetail.ShowDialog() == DialogResult.OK)
			{
				displayData(orderRepository.GetOrders());
				//Focus on updated order
				source.Position = id - 1;
			}
		}

		private void ClearText()
		{
			memberIdTextbox.Text = string.Empty;
			orderIDTextbox.Text = string.Empty;
			orderDateTextbox.Text = string.Empty;
			shippedDateTextbox.Text = string.Empty;
			requiredDateTextbox.Text = string.Empty;
			freightTextbox.Text = string.Empty;
		}

		private Order GetOrder()
		{
			Order order = null;
			try
			{
				order = new Order
				{
					OrderId = int.Parse(orderIDTextbox.Text),
					MemberId = int.Parse(memberIdTextbox.Text),
					OrderDate = DateTime.Parse(orderDateTextbox.Text),
					ShippedDate = shippedDateTextbox.Text.Equals("") ? null : DateTime.Parse(shippedDateTextbox.Text),
					RequiredDate = requiredDateTextbox.Text.Equals("") ? null : DateTime.Parse(requiredDateTextbox.Text),
					Freight = freightTextbox.Text.Equals("") ? 0 : decimal.Parse(freightTextbox.Text)
				};
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error get order " + ex.Message);
			}
			return order;
		}

		private void displayData(Order order)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = order;

				orderIDTextbox.DataBindings.Clear();
				memberIdTextbox.DataBindings.Clear();
				orderDateTextbox.DataBindings.Clear();
				requiredDateTextbox.DataBindings.Clear();
				shippedDateTextbox.DataBindings.Clear();
				freightTextbox.DataBindings.Clear();

				orderIDTextbox.DataBindings.Add("Text", source, "OrderId");
				memberIdTextbox.DataBindings.Add("Text", source, "MemberId");
				orderDateTextbox.DataBindings.Add("Text", source, "OrderDate");
				shippedDateTextbox.DataBindings.Add("Text", source, "ShippedDate");
				requiredDateTextbox.DataBindings.Add("Text", source, "RequiredDate");
				freightTextbox.DataBindings.Add("Text", source, "Freight");

				orderData.DataSource = null;
				orderData.DataSource = source;
				orderData.ForeColor = Color.Black;
				orderData.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load member list");
			}
		}

		private void displayData(IEnumerable<Order> orders)
		{
			if (orders.Count() == 0) orders = orderRepository.GetOrders();
			try
			{
				source = new BindingSource();
				source.DataSource = orders;

				orderIDTextbox.DataBindings.Clear();
				memberIdTextbox.DataBindings.Clear();
				orderDateTextbox.DataBindings.Clear();
				requiredDateTextbox.DataBindings.Clear();
				shippedDateTextbox.DataBindings.Clear();
				freightTextbox.DataBindings.Clear();

				orderIDTextbox.DataBindings.Add("Text", source, "OrderId");
				memberIdTextbox.DataBindings.Add("Text", source, "MemberId");
				orderDateTextbox.DataBindings.Add("Text", source, "OrderDate");
				shippedDateTextbox.DataBindings.Add("Text", source, "ShippedDate");
				requiredDateTextbox.DataBindings.Add("Text", source, "RequiredDate");
				freightTextbox.DataBindings.Add("Text", source, "Freight");

				orderData.DataSource = null;
				orderData.DataSource = source;
				orderData.ForeColor = Color.Black;
				orderData.Refresh();
				if (orders.Count() == 0)
				{
					ClearText();
					deleteButton.Enabled = false;
				}
				else
				{
					deleteButton.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Load orders list");
			}
		}

		private void newButton_Click(object sender, EventArgs e)
		{

			frmOrders frmOrderDetail = new frmOrders
			{
				Text = "Add new Order",
				InsertOrUpdate = false,
				_orderRepository = orderRepository,
			};
			if (frmOrderDetail.ShowDialog() == DialogResult.OK)
			{
				displayData(orderRepository.GetOrders());
				//Focus on new member
				source.Position = source.Count - 1;
			}
		}
		private void loadButton_Click(object sender, EventArgs e)
		{
			var orders = orderRepository.GetOrders();
			displayData(orders);
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			orderRepository.DeleteOrder(int.Parse(orderIDTextbox.Text));
			displayData(orderRepository.GetOrders());
		}

		private void orderButton_Click(object sender, EventArgs e)
		{
			displayData(orderRepository.GetOrders().OrderBy(order => order.OrderDate));
		}

		private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (searchTextbox.Text == null)
			{
				displayData(orderRepository.GetOrders());
				return;
			}
			if (searchComboBox.SelectedIndex == 0)
			{
				displayData(orderRepository.GetOrders());
			}
			else if (searchComboBox.SelectedIndex == 1)
			{
				_ = int.TryParse(searchTextbox.Text, out int id);
				displayData(orderRepository.GetOrders().Where(mem => mem.OrderId == id));
			}
			else if (searchComboBox.SelectedIndex == 2)
			{
				_ = int.TryParse(searchTextbox.Text, out int id);
				displayData(orderRepository.GetOrders().Where(mem => mem.MemberId == id));
			}
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void frmOrder_Load(object sender, EventArgs e)
		{

			deleteButton.Enabled = false;
			loadButton_Click(sender, e);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			frmOrderDetail frm = new frmOrderDetail();
			frm.ShowDialog();
		}

		private void searchTextbox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

