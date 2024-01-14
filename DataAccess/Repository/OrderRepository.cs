using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public class OrderRepository : IOrderRepository
	{
		public void AddNewOrder(Order order)
		{
			OrderDAO.Instance.AddNewOrder(order);
		}

		public void DeleteOrder(int id)
		{
			OrderDAO.Instance.DeleteOrder(id);
		}

		public Order GetOrder(int id)
		{
			return OrderDAO.Instance.GetOrderById(id);
		}

		public IEnumerable<Order> GetOrders()
		{
			return OrderDAO.Instance.GetOrderList();
		}

		public void UpdateOrder(Order order)
		{
			OrderDAO.Instance.UpdateOrder(order);
		}
	}
}
