using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class OrderDetailDao
    {
        private static OrderDetailDao instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDao() { }
        public static OrderDetailDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDao();
                    }
                    return instance;
                }
            }
        }

        public OrderDetail GetOrderDetailByOrderID(int orderID)
        {
            OrderDetail orderdetail = null;
            try
            {
                var db = new ShopingMiniContext();
                orderdetail = db.OrderDetails.SingleOrDefault(orderdetail => orderdetail.OrderId == orderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderdetail;
        }

        public void AddNew(OrderDetail orderdetail)
        {
            try
            {
                OrderDetail _orderdetail = GetOrderDetailByOrderID(orderdetail.OrderId);
                if (_orderdetail == null)
                {
                    var db = new ShopingMiniContext();
                    db.OrderDetails.Add(orderdetail);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Order is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail orderdetail)
        {
            try
            {
                OrderDetail ord = GetOrderDetailByOrderID(orderdetail.OrderId);
                if (ord != null)
                {
                    var db = new ShopingMiniContext();
                    db.Entry<OrderDetail>(orderdetail).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Order does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(OrderDetail orderdetail)
        {
            try
            {
                OrderDetail _orderdetail = GetOrderDetailByOrderID(orderdetail.OrderId);
                if (_orderdetail != null)
                {
                    var db = new ShopingMiniContext();
                    db.OrderDetails.Remove(orderdetail);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Order detail does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
