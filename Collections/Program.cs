using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            DynamicDictionary<int, string> myDictionary = new DynamicDictionary<int, string>();
            myDictionary.Add(37, "Kastamonu");
            Console.WriteLine(myDictionary.Count);

            myDictionary.Add(37, "Kastamonu");

            Console.WriteLine(myDictionary.Count);
            
            myDictionary.Add(01, "Adana");
            myDictionary.Add(34, "Istanbul");

            Console.WriteLine(myDictionary.Count); 
            foreach (var kvp in myDictionary.MyKeyandValuePairs)
            {
                Console.WriteLine(kvp.Key  + "-->" + kvp.Value);
            }

            foreach (var key in myDictionary.GetKeys)
            {
                Console.WriteLine($"Key --> {key}" );
            }
            foreach (var values in myDictionary.GetValues)
            {
                Console.WriteLine($"Value --> {values}");
            }

        }
    }
}
