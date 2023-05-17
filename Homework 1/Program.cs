using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Console.WriteLine();
            Task_2();
            Console.WriteLine();
            Task_3();
        }

        public static void Task_1() 
        {
            Console.Write("Enter the length of the side of the square: ");
            string input = Console.ReadLine();
            int a;

            if (!int.TryParse(input, out a))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");                
            }
            else if (a <= 0)
            {
                Console.WriteLine("The side of the square cannot be zero or less than zero!");
            }
            else
            {              
                int area = a * a;
                int perimeter = a + a + a + a;

                Console.WriteLine("Area is: " + area);
                Console.WriteLine("Perimeter is: " + perimeter);
            }
        }

        public static void Task_2() 
        {
            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            name = name.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            else if (!name.All(char.IsLetter))
            {
                Console.WriteLine("Name can only contain letters!");
                return;
            }

            Console.WriteLine("How old are you, " + name + "?");
            string ageInput = Console.ReadLine();
            int age;

            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine("My name is " + name + " and I'm " + age + " years old.");
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer.");
            }
        }

        public static void Task_3() 
        {
            Console.Write("Enter the radius of a circle:\t");
            string rInput = Console.ReadLine();
            double r;

            if (!double.TryParse(rInput, out r))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            else if (r <= 0)
            {
                Console.WriteLine("The radius of a circle cannot be zero or less than zero!");
            }
            else
            {
                double length = 2 * Math.PI * r;
                double area = Math.PI * r * r;
                double volume = (4 / 3) * Math.PI * Math.Pow(r, 3);

                Console.WriteLine("Length of a circle is:\t " + length);
                Console.WriteLine("Area of a circle is:\t " + area);
                Console.WriteLine("Volume of a circle is:\t " + volume);     
            }
        }
    }
}
