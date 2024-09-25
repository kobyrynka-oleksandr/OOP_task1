using OOP_lab1_TTriangle;

namespace TestTTriangle2
{
    public class Tests
    {
        [Test]
        public void GetPerimeter_3and4and5_returned12()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 12;

            TTriangle triangle = new TTriangle(a, b, c);
            double actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_10and15and20_returned45()
        {
            double a = 10;
            double b = 15;
            double c = 20;
            double expected = 45;

            TTriangle triangle = new TTriangle(a, b, c);
            double actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_3and4and5_returned6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            TTriangle triangle = new TTriangle(a, b, c);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_6and8and10_returned24()
        {
            double a = 6;
            double b = 8;
            double c = 10;
            double expected = 24;

            TTriangle triangle = new TTriangle(a, b, c);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}