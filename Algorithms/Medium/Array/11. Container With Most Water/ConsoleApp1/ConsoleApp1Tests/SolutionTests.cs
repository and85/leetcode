using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        public void MaxAreaTest1()
        {
            // arrange 
            int[] input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7};
            var solution = new Solution();

            // act
            int actual = solution.MaxArea(input);

            // assert
            Assert.AreEqual(49, actual);
        }

        [DataTestMethod()]
        public void MaxAreaTest2()
        {
            // arrange 
            int[] input = new int[] { 1, 1 };
            var solution = new Solution();

            // act
            int actual = solution.MaxArea(input);

            // assert
            Assert.AreEqual(1, actual);
        }
    }
}