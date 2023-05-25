using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hm2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void Task1()
        {
            int minRange = -5;
            int maxRange = 5;

            int numbersAmount = 3;

            for (int i = 0; i < numbersAmount; i++)
            {
                float numbers;
                string inputNumbers = Console.ReadLine();

                if (float.TryParse(inputNumbers, out numbers))
                {
                    if (numbers >= minRange && numbers <= maxRange)
                    {
                        Console.WriteLine("In a range");
                    }
                    else
                    {
                        Console.WriteLine("Not in range");
                    }
                }
                else
                {
                    Console.WriteLine("You can write only number!");
                }
            }
        }

        public static void Task2()
        {
            Console.WriteLine("Write 3 numbers");
            
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                string outputNumbers = Console.ReadLine();
             
                if (!int.TryParse(outputNumbers, out numbers[i]))
                {
                    Console.WriteLine("You can write only number!");
                    return;
                }
            }

            int min = numbers.Min();
            int max = numbers.Max();

            Console.WriteLine("Minimum number: " + min);
            Console.WriteLine("Maximum number: " + max);

        }

                      ////Task3/////

        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404

        }

        public static void Task3()
        {
            Console.Write("Write an Error: ");
            string inputError = Console.ReadLine();

            if (int.TryParse(inputError, out int error) && Enum.IsDefined(typeof(HTTPError), error))
            {
                Console.WriteLine(Enum.GetName(typeof(HTTPError), error));
            }
            else
            {
                Console.WriteLine("Error not found");
            }

        }

                    ////Task4/////
               
        struct Dog 
        {
            public string name { get; set; }
            public string mark { get; set; }
            public int age { get; set; }


            public override string ToString() 
            {
                return $"Your dog's name is {name}, The mark is {mark} and it is {age} years old";            
            }
        }

        public static void Task4()
        {
            Dog dog = new Dog();
         
            Console.Write("Enter your dog's name:\t");
            dog.name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dog.name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            else if (!dog.name.All(char.IsLetter))
            {
                Console.WriteLine("Name can only contain letters!");
                return;
            }

            Console.Write("Enter your dog's mark:\t");
            dog.mark = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dog.mark))
            {
                Console.WriteLine("Mark cannot be empty!");
                return;
            }
            else if (!dog.mark.All(char.IsLetter))
            {
                Console.WriteLine("Mark can only contain letters!");
                return;
            }

            Console.Write("Enter your dog's age:\t");
            string inputAge = Console.ReadLine();

            if (int.TryParse(inputAge, out int age))
            {
                dog.age = age;
            }
            else
            {
                Console.WriteLine("Age can only contain numbers");
                return;
            }

            Console.WriteLine("\nAbout dog: ");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n" + dog.ToString());

            Console.ReadKey();
           
        }





    }
}
