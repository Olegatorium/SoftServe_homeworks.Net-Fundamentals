using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Doctor
    {
        private string _doctorSpecialty, _name, _surname;

        private int _experience;

        private decimal _salary;

        public string DoctorSpecialty
        {
            get { return _doctorSpecialty; }
            set { _doctorSpecialty = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}

