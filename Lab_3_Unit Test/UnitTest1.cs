using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Lab_3_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        CalculateSquareAndCube cal = new CalculateSquareAndCube();
        [TestMethod]
        public void TestSquared()
        {
           // CalculateSquareAndCube cal = new CalculateSquareAndCube();
            int squared = cal.SquareNumber(2);
            Assert.AreEqual(4, squared);
           squared = cal.SquareNumber(10);
            Assert.AreEqual(100, squared);
        }

        [TestMethod]
        public void TestCube()
        {
           // CalculateSquareAndCube cal1 = new CalculateSquareAndCube();
            int cubed = cal.CubeNumber(3);
            Assert.AreEqual(27, cubed);

        }

    }
}
