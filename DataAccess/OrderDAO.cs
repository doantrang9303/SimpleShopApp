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
    public class OrderDAO : BaseDAL
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLook = new ();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null) { instance = new OrderDAO(); }
                }
                return instance;
            }
        }

        public IEnumerable<Order> GetOrderList()
        {
            IDataReader? reader = null;
            string sqlSelect = "Select OrderId,MemberId,OrderDate,RequiredDate,ShippedDate,Freight from [Order]";
            var orders = new List<Order>();
            try
            {
                reader = Provider.GetDataReader(sqlSelect, CommandType.Text, out Connection);
                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderId = reader.GetInt32(0),
                        MemberId = reader.GetInt32(1),
                        OrderDate = reader.GetDateTime(2),
                        RequiredDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                        ShippedDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                        Freight = reader.IsDBNull(5) ? null : reader.GetDecimal(5)
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
            return orders;
        }
        public Order GetOrderById(int id)
        {
            Order order = null;
            IDataReader dataReader = null;
            string sqlQuery = "Select OrderId,MemberId,OrderDate,RequiredDate,ShippedDate,Freight from [Order] where OrderId = @id";
            try
            {
                var param = Provider.CreateParameter("@id", 4, id, DbType.Int32);
                dataReader = Provider.GetDataReader(sqlQuery, CommandType.Text, out Connection, param);
                if (dataReader.Read())
                {
                    order = new Order
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.IsDBNull(3) ? (DateTime?)null : dataReader.GetDateTime(3),
                        ShippedDate = dataReader.IsDBNull(4) ? (DateTime?)null : dataReader.GetDateTime(4),
                        Freight = dataReader.IsDBNull(5) ? null : dataReader.GetDecimal(5)
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
            return order;
        }
        public void AddNewOrder(Order order)
        {
            MemberObject member = MemberDAO.Instance.GetMemberById(order.MemberId)
                ?? throw new Exception("Not Exits member");
            try
            {
                Order newOrder = GetOrderById(order.OrderId);
                if (newOrder == null)
                {
                    string sqlQuery = "Insert [Order] values (@OrderId,@MemberId,@OrderDate,@RequiredDate,@ShippedDate,@Freight)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@OrderDate", 40, order.OrderDate, DbType.DateTime));
                    parameters.Add(Provider.CreateParameter("@RequiredDate", 15, order.RequiredDate.HasValue ? order.RequiredDate : DBNull.Value, DbType.DateTime));
                    parameters.Add(Provider.CreateParameter("@ShippedDate", 15, order.ShippedDate.HasValue ? order.ShippedDate : DBNull.Value, DbType.DateTime));
                    parameters.Add(Provider.CreateParameter("@Freight", 6, order.Freight.HasValue ? order.Freight : DBNull.Value, DbType.Currency));
                    Provider.Insert(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Order has been exists");
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
        public void UpdateOrder(Order order)
        {
            MemberObject member = MemberDAO.Instance.GetMemberById(order.MemberId)
                ?? throw new Exception("Not Exits member");
            try
            {
                Order newOrder = GetOrderById(order.OrderId);
                if (newOrder != null)
                {
                    string sqlQuery = "Update [Order] " +
                        " set MemberId = @MemberId, OrderDate = @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, Freight = @Freight" +
                        " Where OrderId = @OrderId";

                    var parameters = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@OrderDate", 40, order.OrderDate, DbType.DateTime));
                    parameters.Add(Provider.CreateParameter("@RequiredDate", 15, order.RequiredDate.HasValue ? order.RequiredDate : DBNull.Value, DbType.DateTime));
                    parameters.Add(Provider.CreateParameter("@ShippedDate", 15, order.ShippedDate.HasValue ? order.ShippedDate : DBNull.Value, DbType.DateTime));
                    parameters.Add(Provider.CreateParameter("@Freight", 6, order.Freight.HasValue ? order.Freight : DBNull.Value, DbType.Currency));
                    Provider.Update(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Order has not been exits");
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
        public void DeleteOrder(int orderId)
        {
            try
            {
                Order order = GetOrderById(orderId);
                if (order != null)
                {
                    string sqlQuery = "Delete [Order] where OrderId = @OrderId";
                    var param = Provider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32);
                    Provider.Delete(sqlQuery, CommandType.Text, param);
                }
                else { throw new Exception("This Order has not been exits"); }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { Connection.Close(); }
        }
    }
}
