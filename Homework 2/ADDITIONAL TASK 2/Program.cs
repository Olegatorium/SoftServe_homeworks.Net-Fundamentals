using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDITIONAL_TASKS_2
{
    struct Student
    {
        public string LastName { get; set; }
        public int GroupNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total number of students: ");
            string inputStudents = Console.ReadLine();
            
            if (!int.TryParse(inputStudents, out int totalStudents))
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }

            Student[] students = new Student[totalStudents];
            
            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write($"Enter the last name of student {i + 1}: ");
                string lastName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("Name cannot be empty!");
                    return;
                }
                else if (!lastName.All(char.IsLetter))
                {
                    Console.WriteLine("Name can only contain letters!");
                    return;
                }

                Console.Write($"Enter the group number of student {i + 1}: ");
                string inputGroupNumber = Console.ReadLine();
               
                if (!int.TryParse(inputGroupNumber, out int groupNumber))
                {
                    Console.WriteLine("Please enter a valid number");
                    return;
                }

                students[i] = new Student { LastName = lastName, GroupNumber = groupNumber };
            }

            Console.WriteLine("\nOutput information about the student\n");

            Console.Write("Enter the group number: ");
            string inputTargetGroupNumber = Console.ReadLine();
                    
            if (!int.TryParse(inputTargetGroupNumber, out int targetGroupNumber))
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }          

            Console.Write("Enter the starting letter of the last names: ");
            string inputStartingLetter = Console.ReadLine();           

            if (!char.TryParse(inputStartingLetter, out char startingLetter))
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
                return;
            }

            Console.WriteLine($"\nStudents in group {targetGroupNumber} with last names starting with {startingLetter}:");

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GroupNumber == targetGroupNumber && 
                    students[i].LastName[0] == startingLetter)
                {
                    Console.WriteLine(students[i].LastName);
                }
            }

        }
    }

}
