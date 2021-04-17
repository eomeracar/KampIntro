using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Business Classes-->Our rules must be here.
    public class CustomerManager
    {
        IndividualCustomer _individualCustomer;
        public CustomerManager()
        {
            _individualCustomer = new IndividualCustomer();

        }
        public void Add(Customer customer)
        {
            _individualCustomer = (IndividualCustomer)customer;


            Console.WriteLine(_individualCustomer.Name);
            
            /*if(customer.)
            {

            }*/
            //customer.
        }
    }
}
