using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
     abstract class Person
    {
        public int Id;

        protected abstract void Add();
    }
    class Employee : Person
    {
        public Employee()
        {

        }
        public Employee(Person person)
        {
            this.Id = person.Id;
            Add();
        }
        protected override void Add()
        {
            Console.WriteLine("eklendi");
        }
    }
}
