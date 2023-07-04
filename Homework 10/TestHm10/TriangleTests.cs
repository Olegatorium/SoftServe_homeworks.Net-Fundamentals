using System.Drawing;

namespace hm10.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Distance_CalculatesCorrectDistance()
        {
            // Arrange
            hm10.Point p1 = new hm10.Point(2, 4);
            hm10.Point p2 = new hm10.Point(6, 3);
            Triangle triangle = new Triangle(new hm10.Point(0, 0), p1, p2);
            double expectedDistance = 4.123;

            // Act
            double actualDistance = triangle.Distance(p1, p2);

            // Assert
            Assert.AreEqual(expectedDistance, actualDistance, 0.001);
        }

        [TestMethod]
        public void Perimeter_CalculatesCorrectPerimeter()
        {
            // Arrange
            hm10.Point a = new hm10.Point(2, 4);
            hm10.Point b = new hm10.Point(6, 3);
            hm10.Point c = new hm10.Point(5, 8);
            Triangle triangle = new Triangle(a, b, c);
            double expectedPerimeter = 14.222;

            // Act
            double actualPerimeter = triangle.Perimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.001);
        }

        [TestMethod]
        public void Area_CalculatesCorrectArea()
        {
            // Arrange
            hm10.Point a = new hm10.Point(2, 4);
            hm10.Point b = new hm10.Point(6, 3);
            hm10.Point c = new hm10.Point(5, 8);
            Triangle triangle = new Triangle(a, b, c);
            double expectedArea = 9.499;

            // Act
            double actualArea = triangle.Area();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod]
        public void DistanceToOrigin_CalculatesCorrectDistance()
        {
            // Arrange
            hm10.Point a = new hm10.Point(2, 4);
            hm10.Point b = new hm10.Point(6, 3);
            hm10.Point c = new hm10.Point(5, 8);
            Triangle triangle = new Triangle(a, b, c);
            double expectedDistance = 4.472;

            // Act
            double actualDistance = triangle.DistanceToOrigin();

            // Assert
            Assert.AreEqual(expectedDistance, actualDistance, 0.001);
        }
    }
}