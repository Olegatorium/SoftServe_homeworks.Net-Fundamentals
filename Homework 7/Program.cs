using System;
using System.Xml.Linq;

namespace hm7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            string path = "C:\\Users\\Olega\\Desktop\\C# Fundamentals\\phones.txt";

            string newPath = "C:\\Users\\Olega\\Desktop\\C# Fundamentals\\New.txt";

            ////TASK 1

            try
            {
                string[] lines = File.ReadAllLines(path);

                for (int i = 0; i < lines.Length; i++)
                {
                    string phoneNumber = lines[i];

                    if (!phoneBook.ContainsValue(phoneNumber))
                    {
                        Console.Write($"{i + 1}.Enter a name for the number {phoneNumber}:\t");

                        string name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Name cannot be empty!");
                            return;
                        }
                        else if (!name.All(char.IsLetter))
                        {
                            Console.WriteLine("Name can only contain letters!");
                            return;
                        }
                        else if (phoneBook.ContainsKey(name))
                        {
                            Console.WriteLine("This name is already defined. Please write only unique name for each person!");
                            return;
                        }

                        if (!phoneBook.ContainsKey(name))
                            phoneBook.Add(name, phoneNumber);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File phones.txt not found!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading file: " + ex.Message);
            }

            ////TASK 2

            Console.Write("\nEnter the person's name to find their number:\t");

            string findPerson = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(findPerson))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            else if (!findPerson.All(char.IsLetter))
            {
                Console.WriteLine("Name can only contain letters!");
                return;
            }

            if (!(phoneBook.ContainsKey(findPerson)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThere is no person with this name");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNumber of this person is " + phoneBook[findPerson]);
            }

            ////TASK 3
            
            try
            {
                using (StreamWriter sw = new StreamWriter(newPath))
                {
                    foreach (var phoneNumber in phoneBook)
                    {                       
                        sw.WriteLine(ChangePhoneNumberFormat(phoneNumber.Value));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        static string ChangePhoneNumberFormat(string phoneNumber)
        {
            if (phoneNumber.StartsWith("80"))
            {
                phoneNumber = "+38" + phoneNumber.Substring(1);
            }

            return phoneNumber;
        }
    }
}
    
