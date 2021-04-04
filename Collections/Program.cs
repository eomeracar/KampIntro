using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> names = new MyList<string>();
            //names.Add("Test");
            //names.Add("Test2");
            //names.Add("Test3");
            //List<string> names2 = new List<string>();

            //Console.WriteLine(names);
            //Console.WriteLine(names2.Count);


            //foreach (var item in names.Items)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in names2)
            //{

            //}



            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            
            //Console.WriteLine(keyValuePairs.Keys);
            //keyValuePairs.Add("01", "Adana");
            //Console.WriteLine(keyValuePairs.Count);

            //foreach (KeyValuePair<string, string> kvp in keyValuePairs)
            //{
            //    Console.WriteLine(kvp.Key+"-->"+kvp.Value);
            //}

            DynamicDictionary<int, string> myDictionary = new DynamicDictionary<int, string>();
            myDictionary.Add(37, "Kastamonu");
            myDictionary.Add(37, "Kastamonu");
            foreach (var kvp in myDictionary.MyKeyandValuePairs)
            {
                Console.WriteLine(kvp.Item1 + "-->" + kvp.Item2);
            }

            //int[,] vs = new int[0,0];
            //Console.WriteLine(vs.Length);
            //vs[0,0]= 1;
            //Console.WriteLine(vs[0,0]);
        }
    }
}
