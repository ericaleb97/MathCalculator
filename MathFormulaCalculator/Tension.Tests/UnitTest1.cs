using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tension.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingXForces()
        {
            //double weight = 10;
            double T1Angle = 56;
            double T2Angle = 60;

            double angleDegreesXT1 = T1Angle * Math.PI / 180;
            double angleDegreesXT2 = T2Angle * Math.PI / 180;

            var tension = new Tension();

            double T1XActual = tension.T1X;
            double T2XActual = tension.T2X;

            Assert.AreEqual(angleDegreesXT1, T1XActual);
            Assert.AreEqual(angleDegreesXT2, T2XActual);
        }
    }
}
