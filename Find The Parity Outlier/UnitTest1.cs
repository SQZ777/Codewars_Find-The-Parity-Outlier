﻿using System;
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
            getResult(0, new[] { 0, 1, int.MaxValue });
        }

        [TestMethod]
        public void Input_0_1_minInt_Should_Be_1()
        {
            getResult(1, new[] { 0, 1, int.MinValue });
        }

        [TestMethod]
        public void Input_1_3_2_5_Should_Be_2()
        {
            getResult(2, new[] { 1, 3, 2, 5 });
        }

        private static void getResult(int expected, int[] input)
        {
            var kata = new Kata();
            int actual = kata.Find(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int Find(int[] input)
        {
            return input.Where(x => x % 2 == 0).Count() > input.Where(x => x % 2 != 0).Count()
                ?  input.Where(x => x % 2 != 0).First()
                :  input.Where(x => x % 2 == 0).First();

            //if (input.Where(x => x % 2 == 0).Count() > input.Where(x => x % 2 != 0).Count())
            //    return input.Where(x => x % 2 != 0).First();
            //return 0; this code will wrong

            //if (input.Where(x => x % 2 == 0).Count() > input.Where(x => x % 2 != 0).Count())
            //    return input.Where(x => x % 2 != 0).First();
            //return input.Where(x => x % 2 == 0).First();



        }
    }
}
