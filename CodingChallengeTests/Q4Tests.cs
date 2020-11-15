using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Tests
{
    [TestClass()]
    public class Q4Tests
    {
        Q4 q4 = new Q4();
        string str = "interview";
        string strfail = "interviewinterviewinterviewintinterviewinterviewinterv";

        [TestMethod()]
        public void CheckStringLengthTest()
        {
            Assert.AreEqual(false, q4.CheckStringLength(str));
        }
        [TestMethod()]
        public void CheckStringLengthTestFail()
        {
            Assert.AreEqual(true, q4.CheckStringLength(strfail));
        }

        [TestMethod()]
        public void RearrangeStringTest()
        {
            Assert.AreEqual("wvtrniiee", q4.RearrangeString(str));
        }
    }
}