using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer1 = new Customer { Id = 1,Name="Ömer",LastName="Acar",City="Istanbul" };


            Customer customer2 = new Customer(2, "Karcan", "Özbal", "Izmit");
            Console.WriteLine(customer1.Name);
            Console.WriteLine(customer2.Name);

            var number = 11;
            Console.WriteLine();
        }
    }
}
