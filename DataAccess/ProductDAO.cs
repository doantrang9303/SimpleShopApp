using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLook = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null) { instance = new ProductDAO(); }
                }
                return instance;
            }
        }

        public IEnumerable<Product> GetProductList()
        {
            IDataReader? reader = null;
            string sqlSelect = "Select ProductId,CategoryId,ProductName,Weight,UnitPrice,UnitsIsStock from Product";
            var products = new List<Product>();
            try
            {
                reader = Provider.GetDataReader(sqlSelect, CommandType.Text, out Connection);
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductId = reader.GetInt32(0),
                        CategoryId = reader.GetInt32(1),
                        ProductName = reader.GetString(2),
                        Weight = reader.GetString(3),
                        UnitPrice = reader.GetDecimal(4),
                        UnitsIsStock = reader.GetInt32(5)
                    });
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return products;
        }
        public Product GetProductById(int id)
        {
            Product product = null;
            IDataReader? dataReader = null;
            string sqlQuery = "Select ProductId,CategoryId,ProductName,Weight,UnitPrice,UnitsIsStock from Product where ProductId = @id";
            try
            {
                var param = Provider.CreateParameter("@id", 4, id, DbType.Int32);
                dataReader = Provider.GetDataReader(sqlQuery, CommandType.Text, out Connection, param);
                if (dataReader.Read())
                {
                    product = new Product
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsIsStock = dataReader.GetInt32(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return product;
        }
        public void AddNewProduct(Product product)
        {
            try
            {
                Product newProduct = GetProductById(product.ProductId);
                if (newProduct == null)
                {
                    string sqlQuery = "Insert Product values (@ProductId,@CategoryId,@ProductName,@Weight,@UnitPrice,@UnitsIsStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String));
                    parameters.Add(Provider.CreateParameter("@Weight", 15, product.Weight, DbType.String));
                    parameters.Add(Provider.CreateParameter("@UnitPrice", 15, product.UnitPrice, DbType.Currency));
                    parameters.Add(Provider.CreateParameter("@UnitsIsStock", 6, product.UnitsIsStock, DbType.Int32));
                    Provider.Insert(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Product has been exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        //----------------------------------------------------------------------------
        public void UpdateProduct(Product product)
        {
            try
            {
                Product newProduct = GetProductById(product.ProductId);
                if (newProduct != null)
                {
                    string sqlQuery = "Update Product " +
                        " set CategoryId = @CategoryId, ProductName = @ProductName, Weight = @Weight, UnitPrice = @UnitPrice, UnitsIsStock = @UnitsIsStock" +
                        " Where ProductId = @ProductId";

                    var parameters = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String));
                    parameters.Add(Provider.CreateParameter("@Weight", 15, product.Weight, DbType.String));
                    parameters.Add(Provider.CreateParameter("@UnitPrice", 15, product.UnitPrice, DbType.Currency));
                    parameters.Add(Provider.CreateParameter("@UnitsIsStock", 6, product.UnitsIsStock, DbType.Int32));
                    Provider.Update(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Product has not been exits");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        //-------------------------------------------------------------------------
        public void DeleteProduct(int productId)
        {
            try
            {
                Product product = GetProductById(productId);
                if (product != null)
                {
                    string sqlQuery = "Delete Product where ProductId = @ProductId";
                    var param = Provider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32);
                    Provider.Delete(sqlQuery, CommandType.Text, param);
                }
                else { throw new Exception("This Product has not been exits"); }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { Connection.Close(); }
        }
    }
}
