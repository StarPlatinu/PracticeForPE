using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class OrderDao
    {
        private static OrderDao instance = null;
        private static readonly object instanceLock = new object();
        private OrderDao() { }
        public static OrderDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDao();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Order> GetOrdersList()
        {
            List<Order> orders;

            try
            {
                var db = new ShopingMiniContext();
                orders = db.Orders.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return orders;
        }

        public Order GetOrderByID(int orderID)
        {
            Order order = null;
            try
            {
                var db = new ShopingMiniContext();
                order = db.Orders.SingleOrDefault(order => order.OrderId == orderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public void AddNew(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.OrderId);
                if (_order == null)
                {
                    var db = new ShopingMiniContext();
                    db.Orders.Add(order);
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

        public void Update(Order order)
        {
            try
            {
                Order o = GetOrderByID(order.OrderId);
                if (o != null)
                {
                    var db = new ShopingMiniContext();
                    db.Entry<Order>(order).State = EntityState.Modified;
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

        public void Remove(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.OrderId);
                if (_order != null)
                {
                    var db = new ShopingMiniContext();
                    db.Orders.Remove(order);
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
    }
}
