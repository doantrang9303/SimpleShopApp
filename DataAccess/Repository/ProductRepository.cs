using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public class ProductRepository : IProductRepository
	{
		public void AddNewProduct(Product product)
		{
			ProductDAO.Instance.AddNewProduct(product);
		}

		public void DeleteProduct(int id)
		{
			ProductDAO.Instance.DeleteProduct(id);
		}

		public Product GetProductById(int id)
		{
			return ProductDAO.Instance.GetProductById(id);
		}

		public IEnumerable<Product> GetProducts()
		{
			return ProductDAO.Instance.GetProductList();
		}

		public void UpdateProduct(Product product)
		{
			ProductDAO.Instance.UpdateProduct(product);
		}
	}

}
