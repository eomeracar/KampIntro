using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Stock : IEntity
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        
    }
}
