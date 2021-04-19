using GameProject.Business;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           // GamerManager gamerManager = new GamerManager(new UserValidationManager());
          
           //// gamerManager.Add(gamerOmer);

           // List<Gamer> _gamers=gamerManager.GetGamers();
            

           // /*Before Order we need some values
           // *
           // *  GameId=1,
           // *  AddressId=1,
           // *  StockId=1,
           // *  UserId=1
           // **/


           // GameManager gameManager = new GameManager();

           // Stock stock = new Stock()
           // {
           //     Id = 1,
           //     UnitId=1,
           //     Quantity=15
           // };
           // Unit unit = new Unit()
           // {
           //     Id = 1,
           //     UnitName = "Piece"
           // };
           // Address address = new Address()
           // {
           //     Id = 1,
           //     Detail = "Evreşe yolları cad. Dar sok. No:9 Evde Yokuz Apt. Bayrampaşa/IST"
           // };

           // gameManager.Add(new Game()
           // {
           //     Id = 1,
           //     Name = "Game 1 - Game of the Year Edition",
           //     StockId=1
           // });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign() { Id = 1, Name = "New Year Discount",Rate= 15.15m });
            campaignManager.Add(new Campaign
            {
                Id=2,
                Name="Black Firday",
                Rate=10
            });


            OrderManager orderManager = new OrderManager(campaignManager,new MernisUserValidationManager());

            Gamer gamerOmer = new Gamer
            {
                BirthYear = 1995,
                FirstName = "Ömer",
                LastName = "Acar",
                IdentityNumber = 32638672298
            };
            orderManager.DiscountedAdd(new Order()
            {
                OrderNo=1,
                GameId=1,
                AddressId=1,
                Price=1000,
                StockId=1,
                Description="This order for my son,could you please gift wrap?",
                Id=1,
                UserId= gamerOmer.Id
              },
              gamerOmer
              );
        }
    }
}
