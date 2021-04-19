using CoffeetProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeetProject.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Save to db : "+customer.FirstName);
        }
    }
}
