using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.AddNewOrderDetail(orderDetail);
        }

        public void DeleteOrderDetail(int orderId, int productId)
        {
            OrderDetailDAO.Instance.DeleteOrderDetail(orderId, productId);
        }

        public OrderDetail GetOrderDetailById(int orderId, int productId)
        {
             return OrderDetailDAO.Instance.GetOrderDetailById(orderId, productId);
        }

        public IEnumerable<OrderDetail> GetOrderDetailByOrderId(int id)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByOrderId((int)id);
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return OrderDetailDAO.Instance.GetOrderDetailList();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
        }
    }
}
