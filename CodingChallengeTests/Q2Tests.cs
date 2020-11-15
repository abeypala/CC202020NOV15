using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass()]
    public class Q2Tests
    {
        int arrSize1 = 5;
        List<int> inputList1 = new List<int> { 3, 4, 4, 5, 4 };

        int arrSize2 = 4;
        List<int> inputList2 = new List<int> { 1, 1, 8, 2 };

        Q2 q2 = new Q2();

        [TestMethod()]
        public void CheckArraySmoothTestNO()
        {
            Assert.AreEqual("NO", q2.CheckArraySmooth(inputList2));
        }

        [TestMethod()]
        public void CheckArraySmoothTestYES()
        {
            Assert.AreEqual("YES", q2.CheckArraySmooth(inputList1));
        }

        [TestMethod()]
        public void CheckArraySizeTest()
        {
            Assert.AreEqual(false, q2.CheckArraySize(arrSize1));
        }

        [TestMethod()]
        public void CheckArrayElementsTest()
        {
            Assert.AreEqual(false, q2.CheckArrayElements(inputList1));
        }

        [TestMethod()]
        public void CheckArrayElementCountTest()
        {
            Assert.AreEqual(false, q2.CheckArrayElementCount(inputList1, arrSize1));
        }
    }
}