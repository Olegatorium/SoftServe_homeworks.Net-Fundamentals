using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4
{
    class Person
    {
        private string _name;
        private DateTime _birthDate;

        public string Name
        {
            get { return _name; }          
        }

        public DateTime BirthData
        {
            get { return _birthDate; }           
        }

        public Person()
        { 
        
        }

        public Person(string name, DateTime birthYear)
        {
            _name = name;
            _birthDate = birthYear;
        }

        public void Age()
        {
            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - _birthDate.Year;
            int months = currentDate.Month - _birthDate.Month;
            int days = currentDate.Day - _birthDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(_birthDate.Year, _birthDate.Month);
            }

            if (months < 0 || (months == 0 && days < 0))
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Age: {years} years, {months} months, {days} days");
        }

        public static Person InputInfo(int i)
        {
            Console.Write($"Enter name of Person{i}:\t");
            string inputName = Console.ReadLine();

            Console.Write($"Enter Person{i} year of birth:\t");
            string inputYear = Console.ReadLine();

            Console.Write($"Enter Person{i} number month of birth:\t");
            string inputMonth = Console.ReadLine();

            Console.Write($"Enter Person{i} day of birth:\t");
            string inputDay = Console.ReadLine();

            if (!int.TryParse(inputYear, out int year) || !int.TryParse(inputMonth, out int month)
               || !int.TryParse(inputDay, out int day))
            {
                Console.WriteLine("You can only write numbers in name, years and day fields!!!");
                return null; 
            }
            try
            {
                DateTime birthDate = new DateTime(year, month, day);
                Person person = new Person(inputName, birthDate);
                return person;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid date entered. Please enter a valid date!!!");
                return null; 
            }
           
        }

        public void ChangeName()
        {
            Console.WriteLine("Person name is changed");
            string newName = "Very Young";           
            
                _name = newName;
                            
        }

        public override string ToString()
        {
            return $"Name: {_name}, Birth Date: {_birthDate.ToShortDateString()}";
        }

        public void OutPut(int i)
        {
            Console.WriteLine($"Person {i} name is {_name}, birthday is {_birthDate.Day}, birthmonth is {_birthDate.Month}," +
                              $" and bithyear {_birthDate.Year}");
        }

        public int GetAge()
        {
            return DateTime.Now.Year - _birthDate.Year;
        }
    }
}

