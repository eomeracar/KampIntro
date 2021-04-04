using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class DynamicDictionary<K, V>
    {
        (K, V)[] Items;
        bool duplicateInfo = false;
        public DynamicDictionary()
        {
            Items = new (K, V)[0];
        }
        public void Add(K key, V value)
        {
            (K, V)[] tempItems = Items;
            duplicateInfo = CheckDuplicate(tempItems, key);
            if (!duplicateInfo)
            {
                Items = new (K, V)[Items.Length + 1];
                for (int i = 0; i < tempItems.Length; i++)
                {
                    Items[i] = tempItems[i];
                }
                Items[Items.Length - 1] = (key, value);
            }
            else
            {
                Console.WriteLine("Item already exists.");
            }
        }
        public int Count
        {
            get { return Items.Length; }
        }
        public (K, V)[] MyKeyandValuePairs
        {
            get { return Items; }
        }
        public bool CheckDuplicate((K, V)[] items, K key)
        {
            bool result = false;
            foreach (var item in items)
            {
                result = (item.Item1.ToString() == key.ToString()) ? true : false;
            }
            return result;
        }
    }
}