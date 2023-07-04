using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;

namespace hm10
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>
            {
              new Triangle(new Point(2, 4), new Point(6, 3), new Point(5, 8)),
              new Triangle(new Point(1, 2), new Point(3, 6), new Point(7, 4)),
              new Triangle(new Point(1, 2), new Point(3, 2), new Point(4, 5))
            };

            for (int i = 0; i < triangles.Count; i++)
            {
                triangles[i].Print(i + 1);
            }

            Console.WriteLine();

            FindClosestToOriginTriangle(triangles);

            Console.ReadKey();
        }

        public static void FindClosestToOriginTriangle(List<Triangle> triangles)
        {
            var closestTriangle = triangles.Where(t => t != null).MinBy(t => t.DistanceToOrigin());

            int closestTriangleIndex = triangles.IndexOf(closestTriangle) + 1;

            closestTriangle.PrintClosestTriangle(closestTriangleIndex);

        }
    }
}