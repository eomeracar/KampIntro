using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Unit : IEntity
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
    }
}
