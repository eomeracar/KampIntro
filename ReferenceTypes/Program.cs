using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int,decimal,float,enum,boolean-->value types
            /*We can easily see that for value type,the values of variables are not changed after the assignment on the below
              On the other hand,References type variables(in this ex:array is a type that has a type and values) will be changed after the assignment
             */
            int number1= 10;
            int number2 = 20;
            number1 = number2;

            number2 = 100;
            Console.WriteLine($"number1 --> {number1}");

            int[] numbers1 = new int[] { 1, 5, 7 };
            int[] numbers2 = new int[] { 3, 5, 9 };

            numbers1 = numbers2;

            numbers2[0] = 1000;
            Console.WriteLine($"numbers1[0] --> {numbers1[0]}");


            Person person1 = new Person();
            Customer customer = new Customer();
            customer.CreditCardNumber = "1234567890";
            Person person2 = new Person();
            person1.FirstName = "Ömer";
            person2 = person1;
            //Console.WriteLine(person2.FirstName);

            person2.FirstName = "Karcan";
            //Console.WriteLine(person1.FirstName);

            Employee employee = new Employee();

            Person person3 =  customer;
            customer.FirstName = "Ahmet";
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            //Console.WriteLine($"{((Customer)person3).CreditCardNumber }");



        }
    }
}
