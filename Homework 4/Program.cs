using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace hm4
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPeople = 6;

            Person[] people = new Person[amountOfPeople];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = Person.InputInfo(i + 1);

                if (people[i] == null)
                {
                    return;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].ToString());
                people[i].Age();

                Console.WriteLine();            
            }          

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].GetAge() < 16)
                {
                    people[i].ChangeName();
                }

                people[i].OutPut(i + 1);

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i].Name == people[j].Name)
                    {
                        Console.WriteLine($"{people[i]} and {people[j]} are equals");
                    }
                   
                }
            }
        }
    }
}
