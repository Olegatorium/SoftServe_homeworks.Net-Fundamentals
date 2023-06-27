using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8
{
    class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(string name, double length, double width) : base(name)
        {
            _length = length;
            _width = width;
        }

        public override double Area()
        {
            return _length * _width;
        }

        public override double Perimeter()
        {
            return 2 * (_length + _width);
        }
    }

}


   

