using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Surgeon : Doctor
    {
        private int _surgeries;

        public int Surgeries
        {
            get { return _surgeries; }
            set { _surgeries = value; }
        }
    }
}