using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm3
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }

        public static void Task1() 
        {
            string str = Console.ReadLine();
            int countA = 0, countO = 0, countI = 0, countE = 0;

            foreach (char c in str)
            {
                switch (char.ToLower(c))
                {
                    case 'a':
                        countA++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'e':
                        countE++;
                        break;
                }
            }

            Console.WriteLine("\nCount of 'a': " + countA);
            Console.WriteLine("Count of 'o': " + countO);
            Console.WriteLine("Count of 'i': " + countI);
            Console.WriteLine("Count of 'e': " + countE);
        }

        public static void Task2() 
        {
            Console.Write("Enter the number of a month: ");
            string inputMonthNumber = Console.ReadLine();

            if (!int.TryParse(inputMonthNumber, out int monthNumber))
            {
                Console.WriteLine("You can only write numbers!");
                return;
            }

            int daysInMonth;

            switch (monthNumber)
            {
                case 1: // January
                case 3: // March
                case 5: // May
                case 7: // July
                case 8: // August
                case 10: // October
                case 12: // December
                    daysInMonth = 31;
                    break;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    daysInMonth = 30;
                    break;
                case 2: //February

                    Console.WriteLine("Is it a leap month? \nYou can answer yes or no");

                    string answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        daysInMonth = 29;
                    }
                    else if (answer == "no")
                    {
                        daysInMonth = 28;
                    }
                    else
                    {
                        Console.WriteLine("You can only answer yes or no!!!)");
                        return;
                    }
                    break;
                default:
                    daysInMonth = -1;
                    break;
            }

            if (daysInMonth > 0)
            {
                Console.WriteLine("Number of days in the month: " + daysInMonth);
            }
            else
            {
                Console.WriteLine("Invalid month number.");
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Enter 10 integer numbers!)\n");

            int result;

            int amountOfNumbers = 10;

            int[] number = new int[amountOfNumbers];

            for (int i = number[0]; i < number.Length; i++)
            {
                Console.Write($"Number {i + 1} :\t");

                string outputNumbers = Console.ReadLine();

                if (!int.TryParse(outputNumbers, out number[i]))
                {
                    Console.ForegroundColor= ConsoleColor.Red;

                    Console.WriteLine("\nYou can write only numbers!!!");

                    return;
                }                
            }

            if (number[0] >= 0 && number[1] >= 0 && number[2] >= 0 && number[3] >= 0 && number[4] >= 0)              
            {
                result = number[0] + number[1] + number[2] + number[3] + number[4];
            }
            else
            {
                result = number[5] * number[6] * number[7] * number[8] * number[9];
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nYour result:\t" + result);

            Console.ReadKey();          
        } 
    }
}
