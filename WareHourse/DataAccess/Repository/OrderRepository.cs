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
        public Order GetOrderByID(int orderId) => OrderDao.Instance.GetOrderByID(orderId);
        public IEnumerable<Order> GetOrders() => OrderDao.Instance.GetOrdersList();
        public void InsertOrder(Order order) => OrderDao.Instance.AddNew(order);
        public void DeleteOrder(Order order) => OrderDao.Instance.Remove(order);
        public void UpdateOrder(Order order) => OrderDao.Instance.Update(order);
    }
}
