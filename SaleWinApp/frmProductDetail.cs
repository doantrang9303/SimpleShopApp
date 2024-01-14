using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaleWinApps
{
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        public IProductRepository _productRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product productInfo { get; set; }

        private void formProductDetails_Load(object sender, EventArgs e)
        {

            idTextbox.Enabled = false;
            if (InsertOrUpdate) //Update mode
            {
                idTextbox.Text = productInfo.ProductId.ToString();
                categoryTextbox.Text = productInfo.CategoryId.ToString();
                nameTextbox.Text = productInfo.ProductName.ToString();
                weightTextbox.Text = productInfo.Weight.ToString();
                priceTextbox.Text = productInfo.UnitPrice.ToString();
                unitTextbox.Text = productInfo.UnitsIsStock.ToString();
            }
            else
            {
                int lastIndex = _productRepository.GetProducts().ToList().Last().ProductId;
                idTextbox.Text = (lastIndex + 1).ToString();
            }
        }
        private void actionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductId = int.Parse(idTextbox.Text),
                    CategoryId = int.Parse(categoryTextbox.Text),
                    Weight = weightTextbox.Text,
                    ProductName = nameTextbox.Text,
                    UnitPrice = decimal.Parse(priceTextbox.Text),
                    UnitsIsStock = int.Parse(unitTextbox.Text)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
