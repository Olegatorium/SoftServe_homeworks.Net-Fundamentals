using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8
{
    class Cube : Shape, IVolumeCalculable
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public Cube(string name, double side) : base(name)
        {
            _side = side;
            
        }

        public override double Area()
        {
            return 6 * Math.Pow(_side, 2);
        }

        public override double Perimeter()
        {

            return 12 * _side;
        }

        public double Volume()
        {
            return Math.Pow(_side, 3);
        }
    }
}
