using BusinessObject;
using DataAccess.Repository;
using SaleWinApps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaleWinApp
{
	public partial class frmProduct : Form
	{
		IProductRepository productRepository = new ProductRepository();
		BindingSource source;
		public frmProduct()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			displayData(productRepository.GetProducts());
		}

		private void frmProduct_Load(object sender, EventArgs e)
		{

			btnDelete.Enabled = false;
			btnLoad_Click(sender, e);

		}

		private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

			Product product = GetProduct();
			if (product == null) { btnAdd_Click(sender, e); return; };
			frmPreOrder formProductDetails = new frmPreOrder
			{
				Text = "Update a product",
				InsertOrUpdate = true,
				_productRepository = productRepository,
				ProductObject = product,
			};

			int id = int.Parse(txtProductId.Text);
			if (formProductDetails.ShowDialog() == DialogResult.OK)
			{
				var products = productRepository.GetProducts();
				displayData(products);
				//Focus on updated product
				source.Position = id - 1;
			}
		}
		private void ClearText()
		{
			txtCategoryId.Text = string.Empty;
			txtProductId.Text = string.Empty;
			txtProductName.Text = string.Empty;
			txtWeight.Text = string.Empty;
			txtUnitPrice.Text = string.Empty;
			txtUnitslnStock.Text = string.Empty;
		}
		private void displayData(IEnumerable<Product> products)
		{
			if (products.Count() == 0) products = productRepository.GetProducts();
			try
			{
				source = new BindingSource();
				source.DataSource = products;

				txtProductId.DataBindings.Clear();
				txtCategoryId.DataBindings.Clear();
				txtProductName.DataBindings.Clear();
				txtWeight.DataBindings.Clear();
				txtUnitslnStock.DataBindings.Clear();
				txtUnitPrice.DataBindings.Clear();


				txtProductId.DataBindings.Add("Text", source, "ProductId");
				txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
				txtProductName.DataBindings.Add("Text", source, "ProductName");
				txtWeight.DataBindings.Add("Text", source, "Weight");
				txtUnitslnStock.DataBindings.Add("Text", source, "UnitsIsStock");
				txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
				dgvProductList.DataSource = null;
				dgvProductList.DataSource = source;
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
		//private ProductObject GetProductObject()
		//{
		//	ProductObject product = null;
		//	try
		//	{
		//		product = new ProductObject
		//		{
		//			ProductId = int.Parse(txtProductId.Text),
		//			CategoryId = int.Parse(txtCategoryId.Text),
		//			ProductName = txtProductName.Text,
		//			Weight = txtWeight.Text,
		//			UnitPrice = Decimal.Parse(txtUnitPrice.Text),
		//			UnitslnStock = int.Parse(txtUnitslnStock.Text),
		//		};
		//	}
		//	catch (Exception ex) { MessageBox.Show(ex.Message, "Get Product"); }
		//	return product;
		//}


		private void btnOrder_Click(object sender, EventArgs e)
		{
			//OrderDetailObject order = null;
			//try
			//{
			//	order = new OrderDetailObject
			//	{
			//		ProductId = int.Parse(txtProductId.Text),
			//		UnitPrice = Decimal.Parse(txtUnitPrice.Text),
			//		Quanlity = int.Parse(a),
			//		Discount = Decimal.Parse(txtUnitPrice.Text),
			//	};

			//	orderDetailRepository.InsertOrderDetail(order);
			//	MessageBox.Show("Success");
			//}
			//catch (Exception ex) { MessageBox.Show(ex.Message); }
		}


		private void btnOrderDetail_Click(object sender, EventArgs e)
		{
			frmOrderDetail frm = new frmOrderDetail();

			frm.ShowDialog();
		}

		private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmPreOrder formProductDetails = new frmPreOrder
			{
				Text = "Add new product",
				InsertOrUpdate = false,
				_productRepository = productRepository,
			};
			if (formProductDetails.ShowDialog() == DialogResult.OK)
			{
				var products = productRepository.GetProducts();
				displayData(products);
				//Focus on new member
				source.Position = source.Count - 1;
			}
		}





		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtCreate_Click(object sender, EventArgs e)
		{
			frmProductDetail formProductDetails = new frmProductDetail
			{
				Text = "Add new product",
				InsertOrUpdate = false,
				_productRepository = productRepository,
			};
			if (formProductDetails.ShowDialog() == DialogResult.OK)
			{
				var products = productRepository.GetProducts();
				displayData(products);
				//Focus on new member
				source.Position = source.Count - 1;
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var product = new Product
				{
					ProductId = int.Parse(txtProductId.Text),
					CategoryId = int.Parse(txtCategoryId.Text),
					ProductName = txtProductName.Text,
					Weight = txtWeight.Text,
					UnitPrice = Decimal.Parse(txtUnitPrice.Text),
					UnitsIsStock = int.Parse(txtUnitslnStock.Text),
				};

				productRepository.UpdateProduct(product);

				MessageBox.Show("Success");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			productRepository.DeleteProduct(int.Parse(txtProductId.Text));
			var products = productRepository.GetProducts();
			displayData(products);
		}
		private Product GetProduct()
		{
			Product product = null;
			if (int.Parse(txtProductId.Text) == 0) return product;
			try
			{
				product = new Product
				{
					ProductId = int.Parse(txtProductId.Text),
					CategoryId = int.Parse(txtCategoryId.Text),
					Weight = txtWeight.Text,
					ProductName = txtProductName.Text,
					UnitPrice = !txtUnitPrice.Equals("Null") ? decimal.Parse(txtUnitPrice.Text) : 0,
					UnitsIsStock = !txtUnitslnStock.Equals("0") ? int.Parse(txtUnitslnStock.Text) : 0
				};
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error get product " + ex.Message);
			}
			return product;
		}

		private void searchComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (txtSearch.Text == null)
			{
				displayData(productRepository.GetProducts());
				return;
			}
			if (searchComboBox.SelectedIndex == 0)
			{
				displayData(productRepository.GetProducts());
			}
			else if (searchComboBox.SelectedIndex == 1)
			{
				_ = int.TryParse(txtSearch.Text, out int id);
				displayData(productRepository.GetProducts().Where(mem => mem.ProductId == id));
			}
			else if (searchComboBox.SelectedIndex == 2)
			{
				_ = int.TryParse(txtSearch.Text, out int id);
				displayData(productRepository.GetProducts().Where(mem => mem.CategoryId == id));
			}
			else if (searchComboBox.SelectedIndex == 3)
			{
				displayData(productRepository.GetProducts().Where(mem => mem.ProductName.ToLower().Contains(txtSearch.Text)));
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			frmOrder frm = new frmOrder();
			
			frm.ShowDialog();
		}
	}
}
