using BusinessObject;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
	public partial class frmPreOrder : Form
	{
		//public IProductRepository _productRepository = new ProductRepository();
		public IProductRepository _productRepository { get; set; }
		BindingSource source;
		public bool InsertOrUpdate { get; set; }
		public Product ProductObject { get; set; }
		public frmPreOrder()
		{
			InitializeComponent();
		}

		private void btnOrder_Click(object sender, EventArgs e)
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
				if (InsertOrUpdate)
				{
					_productRepository.UpdateProduct(product);
				}
				else
				{
					_productRepository.AddNewProduct(product);
				}
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, InsertOrUpdate ? "Error Update a product " : "Error Insert a new product");
			}
		}

		private void frmPreOrder_Load(object sender, EventArgs e)
		{
			txtProductId.Enabled = !InsertOrUpdate;
			if (InsertOrUpdate == true)
			{
				txtProductId.Text = ProductObject.ProductId.ToString();
				txtCategoryId.Text = ProductObject.CategoryId.ToString();
				txtWeight.Text = ProductObject.Weight.ToString();
				txtUnitPrice.Text = ProductObject.UnitPrice.ToString();
				txtUnitslnStock.Text = ProductObject.UnitsIsStock.ToString();
			}

			//else
			//{
			//	int lastIndex = _productRepository.GetProducts().ToList().Last().ProductId;
			//	txtProductId.Text = (lastIndex + 1).ToString();
			//}

		}
	}
}
