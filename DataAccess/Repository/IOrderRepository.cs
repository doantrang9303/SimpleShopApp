using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetOrders();
        public Order GetOrder(int id);
        public void UpdateOrder(Order order);
        public void AddNewOrder(Order order);
        public void DeleteOrder(int id);
    }
}
