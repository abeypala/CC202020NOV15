using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass()]
    public class Q3Tests
    {
        int arrSize1 = 5;
        List<int> inputList1 = new List<int> { 6, 1, 5, 9, 2};
        Q3 q3 = new Q3();

        [TestMethod()]
        public void SubSequenceFinderTest()
        {
            Assert.AreEqual("1 5 9", q3.SubSequenceFinder(inputList1));
        }
    }
}