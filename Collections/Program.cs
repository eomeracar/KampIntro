using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Test");
            names.Add("Test2");
            names.Add("Test3");

            Console.WriteLine("Hello World!");
            Console.WriteLine(names.Length);
            foreach(var item in names.Items)
            {
                Console.WriteLine(item);
            }

            List<string> names2 = new List<string>();
            foreach (var item in names2)
            {

            }
        }
    }
}
