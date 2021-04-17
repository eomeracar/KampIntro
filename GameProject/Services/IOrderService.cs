using GameProject.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Services
{
    interface IOrderService
    {
        void Add(Order order);
        void Add(List<Order> orders);
    }
}
