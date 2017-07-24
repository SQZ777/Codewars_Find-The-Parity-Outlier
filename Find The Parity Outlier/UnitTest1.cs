using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Find_The_Parity_Outlier
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_1_Maxint_Should_Be_0()
        {
            var kata = new Kata();
            int[] input = { 0, 1, int.MaxValue };
            int actual = kata.Find(input);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int Find(int[] input)
        {
            throw new NotImplementedException();
        }
    }
}
