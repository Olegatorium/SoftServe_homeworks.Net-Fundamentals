using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm10
{
    public class Triangle
    {
        private Point _a, _b, _c;

        public Triangle(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Distance(Point p1, Point p2)
        {
            int deltaX = p2.x - p1.x;
            int deltaY = p2.y - p1.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public double Perimeter()
        {
            double side1 = Distance(_a, _b);
            double side2 = Distance(_b, _c);
            double side3 = Distance(_c, _a);
            return side1 + side2 + side3;
        }

        public double Area()
        {
            double side1 = Distance(_a, _b);
            double side2 = Distance(_b, _c);
            double side3 = Distance(_c, _a);
            double semiperimeter = Perimeter() / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }

        public void Print(int i)
        {
            Console.WriteLine($"Triangle {i}: has perimeter: {Perimeter()} and area: {Area()}" +
                $" and vertexes: {_a.ToString()}, {_b.ToString()}, {_c.ToString()}");
        }

        public double DistanceToOrigin()
        {
            Point origin = new Point(0, 0);
            return Math.Min(Distance(_a, origin), Math.Min(Distance(_b, origin), Distance(_c, origin)));
        }

        public void PrintClosestTriangle(int closestTriangle)
        {
            Console.WriteLine($"Triangle closest to origin is: Triangle {closestTriangle}");
        }
    }
}