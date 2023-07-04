using System.Drawing;

namespace hm10.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void TestPointToString()
        {
            //arrange
            Point point = new Point(2,4);

            string expected = "(2,4)";

            //actual
            string actual = point.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}