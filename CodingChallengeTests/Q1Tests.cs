using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.Tests
{
    [TestClass()]
    public class Q1Tests
    {

        [TestMethod()]
        public void FibonacciLikeTest()
        {
            Q1 q1 = new Q1();
            Assert.AreEqual(3, q1.FibonacciLike(1, 2, 3));
        }

        [TestMethod()]
        public void FibonacciLikeTestTake2()
        {
            // flower petals >> 1, 1, 2, 3, 5, 8, 13, 21, 34, 55(10), 89, 134, 223, ...
            Q1 q1 = new Q1();
            Assert.AreEqual(55, q1.FibonacciLike(1, 1, 10));
        }


    }
}