using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.ListCollections
{
    internal class PredicateAndDelegate
    {
         public T  AddItem<T>(T Instance ,string item) where T : List<string>
        {
            if(string.IsNullOrWhiteSpace(item))
            {
                Console.WriteLine("Item cannot be null or empty.");
                return Instance;
            };
            Instance.Add(item);
            return Instance;
        }
        public void DisplayList(List<string> list)
        {
            foreach(string item in list)
            {
                Console.WriteLine("Item List: " + item);
            }

        }

        public List<string> FilterList(List<string> dataList,Predicate<string> predicate)
        {
            List<string> filterData = dataList.FindAll(predicate).ToList();
            return filterData;
        }
    }
}
