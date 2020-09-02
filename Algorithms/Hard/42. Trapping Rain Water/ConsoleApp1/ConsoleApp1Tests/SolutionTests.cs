using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        [DataRow(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        public void TrapTest(int[] input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.Trap(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}