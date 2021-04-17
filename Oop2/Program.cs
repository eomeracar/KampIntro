using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        { 

           
        //{
        //    IndividualCustomer customer1 = new IndividualCustomer();
        //    customer1.Id = 1;
        //    customer1.Name = "Ömer";
        //    customer1.SurName = "Acar";
        //    customer1.TcNo = "1111111111";
        //    customer1.CustomerNo = "123456789";

        //    //Gerçek Müşteri - Tüzel Müşteri
        //    //Tüzel Müşteri
        //    CorporateCustomer customer2 = new CorporateCustomer();
        //    customer2.Id = 2;
        //    customer2.TaxNo = "1234567890";
        //    customer2.CustomerNo = "111111111";
        //    customer2.CompanyName = "Softac A.Ş.";




        //    Customer customer3 = new CorporateCustomer();








            Customer customer4 = new IndividualCustomer() { Id = 5,Name="Ömer",SurName="Acar",CustomerNo="5",TcNo="33322" };
            
            

            //Bireysel Müşteri
            //  IndividualCustomer customer5 = new IndividualCustomer();
            Console.WriteLine(customer4.CustomerNo);
            


            //customer5.CustomerNo = "1";
            //customer5.Id = 4;
            //customer5.Name = "Ahmet";
            //customer5.SurName = "Nejdet";
            //customer5.TcNo = "1111111113";




            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer4);
            //customerManager.Add(customer1);
            //customerManager.Add(customer2);
            //customerManager.Add(customer3);

            //Console.WriteLine("Hello World!");




            Person person = new Employee(new Employee { Id=8});
            //Console.WriteLine(person.Id);

        }
    }
}
