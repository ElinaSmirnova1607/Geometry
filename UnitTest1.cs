using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatchTask_SmirFergs_;

namespace MatchTest_SmirFergs_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int h = 5;
            int expected = 141;
            Geometry g = new Geometry();
            double actual = g.RectangleArea(a, h);

            Assert.AreEqual(expected, actual);
        }
    }
}
