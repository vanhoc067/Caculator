using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caculator;
using System;

namespace Unit_Test
{
    [TestClass]
    public class Test_Cau1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x, ketQua;
            int n;
            x = 3;
            n = 0;
            ketQua = 1;       
            Assert.AreEqual(ketQua, FCau1.Power(x, n));
        }
    }
}
