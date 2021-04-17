using GameProject.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class CampaignManager : ICampaignService
    {
        
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is Added --> "+campaign.Name);
            _campaign= campaign;
        }

        public void ApplyCampaign(Order order)
        {
            order.Price = (order.Price) - ((order.Price * _campaign.Rate)/100);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is Deleted --> " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is Modified --> " + campaign.Name);
        }
        public List<Campaign> _campaigns
        {
            get;
            set;
        }
        public Campaign _campaign
        {
            get;
            set;
        }

    }
}
