using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.ListCollections
{
    internal class HashTableClass
    {
        Hashtable Hashtable = new Hashtable();
         public void AddItem(object key, object value)
                    {
            if(key == null || value == null)
            {
                Console.WriteLine("Key and Value cannot be null.");
                return;
            }
            Hashtable.Add(key, value);
        }

        public void DisplayItem(object key)
        {
            if (Hashtable.ContainsKey(key))
            {
                Console.WriteLine($"Value for key '{key}': {Hashtable[key]}");
   
            }
            else
            {
                Console.WriteLine("Key not found in the hashtable.");
          
            }
        }
    }
}
