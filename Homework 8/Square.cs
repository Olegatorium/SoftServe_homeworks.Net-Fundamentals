using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8
{
    class Square : Shape
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public Square(string name, double side) : base(name)
        {
            _side = side;
        }

        public override double Area()
        {
            return Math.Pow(_side, 2);
        }

        public override double Perimeter()
        {
            return 4 * _side;
        }
    }
}
