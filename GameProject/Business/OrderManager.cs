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
        IUserValidationService _userValidationService;
        public OrderManager(ICampaignService campaignService,IUserValidationService userValidationService)
        {
            _campaignService = campaignService;
            _userValidationService = userValidationService;
        }
        public void Add(Order order)
        {
            Console.WriteLine("Order is Added");
        }
        public void DiscountedAdd(Order order,Gamer gamer)
        {
           if( _userValidationService.Validate(gamer)==true)
            { 
            _campaignService.ApplyCampaign(order);
            Console.WriteLine($"Your Order number is {order.OrderNo }");
            Console.WriteLine($"New Price is {order.Price}");
            Console.WriteLine("Giriş başarılı");
            }
            else 
            { 
            Console.WriteLine($"You must enter the system first.");
            }
        }

        public void Add(List<Order> orders)
        {

        }
    }
}
