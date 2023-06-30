using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm9
{
    class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }

}
