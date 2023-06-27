using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8
{
	abstract class Shape : IComparable<Shape>
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public Shape(string name)
		{
			_name = name;
		}

		public abstract double Area();
		public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            if (other == null)
                return 1;

            return Area().CompareTo(other.Area());
        }

    }
}
