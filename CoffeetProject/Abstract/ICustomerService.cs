using CoffeetProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeetProject.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
