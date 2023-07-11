using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Pediatrician : Doctor
    {
        private int _declaredPatients;

        public int DeclaredPatients
        {
            get { return _declaredPatients; }
            set { _declaredPatients = value; }
        }
    }
}