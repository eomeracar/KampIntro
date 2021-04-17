using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace GameProject.Business
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public void Add(Order order)
        {
            Console.WriteLine("Order is Added");
        }
        public void DiscountedAdd(Order order)
        {
            _campaignService.ApplyCampaign(order);
            Console.WriteLine($"Your Order number is {order.OrderNo }");
            Console.WriteLine($"New Price is {order.Price}");
        }

        public void Add(List<Order> orders)
        {

        }
    }
}
