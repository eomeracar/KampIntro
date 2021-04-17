using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
    }
}
