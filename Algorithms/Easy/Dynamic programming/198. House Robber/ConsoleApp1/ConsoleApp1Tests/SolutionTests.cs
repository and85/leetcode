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
        [DataRow(new int[] { 1, 2, 3, 1 }, 4)]
        [DataRow(new int[] { 2, 7, 9, 3, 1 }, 12)]
        public void RobTest(int[] input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.Rob(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}