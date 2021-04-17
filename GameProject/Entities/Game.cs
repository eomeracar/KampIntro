using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Game:IEntity
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public string Name { get; set; }
    }
}
