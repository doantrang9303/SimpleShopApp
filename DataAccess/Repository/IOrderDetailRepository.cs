using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails();
        public IEnumerable<OrderDetail> GetOrderDetailByOrderId(int id);
        public OrderDetail GetOrderDetailById(int orderId, int productId);
        public void AddNewOrderDetail(OrderDetail orderDetail);
        public void UpdateOrderDetail(OrderDetail orderDetail);
        public void DeleteOrderDetail(int orderId, int productId);

    }
}
