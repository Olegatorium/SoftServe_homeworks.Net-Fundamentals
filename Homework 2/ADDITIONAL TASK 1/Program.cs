using ADDITIONAL_TASKS_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDITIONAL_TASKS_1
{
    enum Food
    {
        Fish,
        Mouse,
        Kitycat,
        Sausages
    }
    interface IFullnessLevel
    {
        void Level1();
        void Level2();
        void Level3();
        void Level4();
        void PrintAssortment();
    }
    class CatSatiety : IFullnessLevel
    {
        public void Level1()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nCat say:\n");
            Console.WriteLine("I'm not full :(");
        }

        public void Level2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCat say:\n");
            Console.WriteLine("I had a bite to eat :|");
        }

        public void Level3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nCat say:\n");
            Console.WriteLine("I ate my fill ;)");
        }

        public void Level4()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\nCat say:\n");
            Console.WriteLine("I will never eat again :-]");
        }

        public void PrintAssortment()
        {
            Console.WriteLine($"Our assortment for a cat: \n\n1.{nameof(Food.Fish)}" +
                $"\n2. {nameof(Food.Mouse)} \n3. {nameof(Food.Kitycat)} \n4. {nameof(Food.Sausages)}\n");
        }
    }
    class Cat
    {
        public void Satiety(IFullnessLevel fullnessLevel)
        {
            fullnessLevel.PrintAssortment();

            Console.WriteLine("Choose one food for a cat:\n");

            string eat = Console.ReadLine();

            if (eat.ToLower() == nameof(Food.Fish).ToLower())
            {
                fullnessLevel.Level1();
            }
            else if (eat.ToLower() == nameof(Food.Mouse).ToLower())
            {
                fullnessLevel.Level2();
            }
            else if (eat.ToLower() == nameof(Food.Kitycat).ToLower())
            {
                fullnessLevel.Level3();
            }
            else if (eat.ToLower() == nameof(Food.Sausages).ToLower())
            {
                fullnessLevel.Level4();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("\nWe don't have this in our assortment :(");
            }
        }
    }

}
    class Program
    {
        static void Main(string[] args)
        {
           Cat cat = new Cat();
       
           cat.Satiety(new CatSatiety());
        }
    }

