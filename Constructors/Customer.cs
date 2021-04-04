using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        //Default Constructor
        public Customer(int id,string name,string lastName,string city)
        {
            Console.WriteLine("Constructor is Worked");
            Id = id;
            Name = name;
            LastName = lastName;
            City = city;
        }
        public Customer()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
