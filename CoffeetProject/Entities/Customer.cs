using CoffeetProject.Abstract;
using System;

namespace CoffeetProject.Entities
{
        public class Customer : IEntity
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string NationalityId { get; set; }

        }
}
