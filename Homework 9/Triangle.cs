using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm9
{
    class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        public double SideC
        {
            get { return _sideC; }
            set { _sideC = value; }
        }

        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double Area()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public override double Perimeter()
        {
            return _sideA + _sideB + _sideC;
        }
    }
}
