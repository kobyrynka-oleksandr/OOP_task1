using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TTrinagleTest
{
    [TestClass]
    public class TTrinagleTest
    {
        [TestMethod]
        public void Perimeter_3and4and5_12returned()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int expected = 12;

            TTrinagle trinagle = new TTrinagle(a, b, c);
            int actual = trinagle.Perimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}
