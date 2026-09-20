using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.ListCollections
{
    public struct UserObject
    {
        public int Id;
        public string Name;
        public string Email;
        public int Age;
        public string City;
        public bool IsActive;
    }
    internal class ListCollectionClass
    {
        List<string> dataList = new List<String>();
        List<UserObject> userList = new List<UserObject>();

        public void AddItem(string items)
        {
            dataList.Add(items);
        }
        public void InsertAtIndex(int index, string item)
        {
            if(index >=0 && index  <= dataList.Count)
            {
                dataList.Insert(index, item);
            }
            else
            {
                Console.WriteLine("Index is out of range. Please provide a valid index.");
            }
        }
        public void RemoveItem(string items)
        {
            if (dataList.Contains(items))
            {
                dataList.Remove(items);
            }
            else
            {
                Console.WriteLine("Item not found in the list.");
            }
        }


        public void DisplayList()
        {
            foreach(string item in dataList)
            {
                Console.WriteLine(item);

            }
        }
    
        public void AddUser(UserObject user)
        {
            userList.Add(user);
        }

        public void DisplayUserList()
        {
            foreach (var user in userList)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}, Age: {user.Age}, City: {user.City}, IsActive: {user.IsActive}");
            }
        }


    }
}
