﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderByID(int id);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        void InsertOrder(Order order);
    }
}
