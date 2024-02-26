using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day1Test
{
    [TestClass]
    public class calcWeightTest
    {
        [TestMethod]
        public void GetWight_170_M_return_65()
        {
            calcWeight CW = new calcWeight
            {
                hight = 170,
                gender = 'M'
            };
            double result = CW.claculationWeight();
            double resultExpected = 65;
            Assert.AreEqual(resultExpected, result);


        }

        [TestMethod]
        public void GetWight_176_F_return_63()
        {
            calcWeight CW = new calcWeight
            {
                hight = 176,
                gender = 'F'
            };
            double result = CW.claculationWeight();
            double resultExpected = 63;
            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void GetWight_170_Z_return_0()
        {
            calcWeight CW = new calcWeight
            {
                hight = 176,
                gender = 'Z'
            };
            double result = CW.claculationWeight();
            double resultExpected = 0;
            Assert.AreEqual(resultExpected, result);
        }

    }
}
