using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer : IEntity
    {
        public int Id { get; set; }
        public long IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

    }
}
