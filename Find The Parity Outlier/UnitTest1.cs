using System;
using System.Linq;
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

        [TestMethod]
        public void Input_0_1_minInt_Should_Be_1()
        {
            var kata = new Kata();
            int[] input = { 0, 1, int.MinValue };
            int actual = kata.Find(input);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int Find(int[] input)
        {
            if (input.Where(x=>x%2==0).Count() > input.Where(x => x % 2 != 0).Count())
            {
                return 1;
            }
            return 0;
        }
    }
}
