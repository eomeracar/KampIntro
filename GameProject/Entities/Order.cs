using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business
{
    class Order : IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int StockId { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int OrderNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
