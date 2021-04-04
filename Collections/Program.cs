using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicDictionary<int, string> myDictionary = new DynamicDictionary<int, string>();
            myDictionary.Add(37, "Kastamonu");
            Console.WriteLine(myDictionary.Count);

            myDictionary.Add(37, "Kastamonu");

            Console.WriteLine(myDictionary.Count); 
            foreach (var kvp in myDictionary.MyKeyandValuePairs)
            {
                Console.WriteLine(kvp.Key  + "-->" + kvp.Value);
            }

        }
    }
}
