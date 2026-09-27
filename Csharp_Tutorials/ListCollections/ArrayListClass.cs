using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Csharp_Tutorials.ListCollections
{
    internal class ArrayListClass
    {
        ArrayList arrayList = new ArrayList();

        public void AddItem(object item)
        {
            if (typeof(object) == typeof(string) && (string.IsNullOrEmpty(item as string) || string.IsNullOrWhiteSpace(item as string)))
            {
                Console.WriteLine("Item cannot be null or empty.");
            }
            else
            {
                arrayList.Add(item);
            }
        }

        public void DisplayList()
        {
            foreach(object item in arrayList)
            {
                Console.WriteLine("Item List: " + item);
            }
        }
    }
}
