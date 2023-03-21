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
        public OrderDetail GetOrderDetailByOrderID(int orderId) => OrderDetailDao.Instance.GetOrderDetailByOrderID(orderId);
        public void InsertOrderDetail(OrderDetail orderdetail) => OrderDetailDao.Instance.AddNew(orderdetail);
        public void DeleteOrderDetail(OrderDetail orderdetail) => OrderDetailDao.Instance.Remove(orderdetail);
        public void UpdateOrderDetail(OrderDetail orderdetail) => OrderDetailDao.Instance.Update(orderdetail);

       
    }
}
