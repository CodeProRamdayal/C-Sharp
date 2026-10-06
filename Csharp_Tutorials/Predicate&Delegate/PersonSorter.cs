using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Predicate_Delegate
{
    internal class PersonSorter
    {
        public static void Sort(Persons[] people, Comparison<Persons> comparison)
        {

            for(int i=0;i < people.Length; i++)
            {
                for(int j= i+1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Persons temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }

        }
   
        public static int CompareByAge(Persons p1,Persons p2)
        {
            return p1.Age.CompareTo(p2.Age);
        }
        public static int CompareByName(Persons p1, Persons p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }

    }
}
