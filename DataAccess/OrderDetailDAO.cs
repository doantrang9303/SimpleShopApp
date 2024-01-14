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
    public class OrderDetailDAO : BaseDAL
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLook = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null) { instance = new OrderDetailDAO(); }
                }
                return instance;
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            IDataReader? reader = null;
            string sqlSelect = "Select OrderId,ProductId,UnitPrice,Quantity,Discount from OrderDetail";
            var orderdetails = new List<OrderDetail>();
            try
            {
                reader = Provider.GetDataReader(sqlSelect, CommandType.Text, out Connection);
                while (reader.Read())
                {
                    orderdetails.Add(new OrderDetail
                    {
                        OrderId = reader.GetInt32(0),
                        ProductId = reader.GetInt32(1),
                        UnitPrice = reader.GetDecimal(2),
                        Quantity = reader.GetInt32(3),
                        Discount = (float) reader.GetDouble(4)
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
            return orderdetails;
        }
        public IEnumerable<OrderDetail> GetOrderDetailByOrderId(int id)
        {
            var orderdetails = new List<OrderDetail>();
            IDataReader? dataReader = null;
            string sqlQuery = "Select OrderId,ProductId,UnitPrice,Quantity,Discount from OrderDetail where OrderId = @id";
            try
            {
                var param = Provider.CreateParameter("@id", 4, id, DbType.Int32);
                dataReader = Provider.GetDataReader(sqlQuery, CommandType.Text, out Connection, param);
                while (dataReader.Read())
                {
                    orderdetails.Add(new OrderDetail
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4)
                    });
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
            return orderdetails;
        }

        public OrderDetail GetOrderDetailById(int orderId, int productId)
        {
            OrderDetail orderDetail = null;
            IDataReader? dataReader = null;
            string sqlQuery = "Select OrderId,ProductId,UnitPrice,Quantity,Discount from OrderDetail where OrderId = @orderId and ProductId = @productId";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(Provider.CreateParameter("@orderId", 4, orderId, DbType.Int32));
                parameters.Add(Provider.CreateParameter("@productId", 4, productId, DbType.Int32));
                dataReader = Provider.GetDataReader(sqlQuery, CommandType.Text, out Connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    orderDetail = new OrderDetail
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4)
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
            return orderDetail;
        }
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            var order = OrderDAO.Instance.GetOrderById(orderDetail.OrderId) ?? throw new Exception("Order not exits");
            var product = ProductDAO.Instance.GetProductById(orderDetail.ProductId) ?? throw new Exception("Product not exits");
            try
            {
                OrderDetail newOrderDetail = GetOrderDetailById(orderDetail.OrderId,orderDetail.ProductId);
                if (newOrderDetail == null)
                {
                    string sqlQuery = "Insert OrderDetail values (@OrderId,@ProductId,@UnitPrice,@Quantity,@Discount)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@OrderId", 4, orderDetail.OrderId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@ProductId", 4, orderDetail.ProductId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@UnitPrice", 40, orderDetail.UnitPrice, DbType.Currency));
                    parameters.Add(Provider.CreateParameter("@Quantity", 15, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@Discount", 15,orderDetail.Discount, DbType.Double));
                    Provider.Insert(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The OrderDetail has been exists");
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
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            var order = OrderDAO.Instance.GetOrderById(orderDetail.OrderId) ?? throw new Exception("Order not exits");
            var product = ProductDAO.Instance.GetProductById(orderDetail.ProductId) ?? throw new Exception("Product not exits");
            try
            {
                OrderDetail newOrderDetail = GetOrderDetailById(orderDetail.OrderId,orderDetail.ProductId);
                if (newOrderDetail != null)
                {
                    string sqlQuery = "Update OrderDetail " +
                        "set UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount" +
                        " Where OrderId = @OrderId and ProductId = @ProductId";

                    var parameters = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@ProductId", 4, orderDetail.ProductId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@OrderId", 4, orderDetail.OrderId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@UnitPrice", 40, orderDetail.UnitPrice, DbType.Currency));
                    parameters.Add(Provider.CreateParameter("@Quantity", 15, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@Discount", 15,orderDetail.Discount, DbType.Double));
                    Provider.Update(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Orderdetail has not been exits");
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
        public void DeleteOrderDetail(int orderId, int productId)
        {
            try
            {
                OrderDetail orderDetail = GetOrderDetailById(orderId,productId);
                if (orderDetail != null)
                {
                    string sqlQuery = "Delete OrderDetail where ProductId = @ProductId and OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add( Provider.CreateParameter("@ProductId", 4, orderDetail.ProductId, DbType.Int32));
                    parameters.Add( Provider.CreateParameter("@OrderId", 4, orderDetail.OrderId, DbType.Int32));
                    Provider.Delete(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else { throw new Exception("This OrderDetail has not been exits"); }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { Connection.Close(); }
        }
    }
}
