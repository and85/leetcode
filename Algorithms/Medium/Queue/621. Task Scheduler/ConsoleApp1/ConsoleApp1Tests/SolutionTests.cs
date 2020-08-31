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
        //[DataRow(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2, 8)]
        //[DataRow(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 0, 6)]
        //[DataRow(new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }, 2, 16)]
        [DataRow(new char[] { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'D', 'D', 'E' }, 2, 12)]
        public void LeastIntervalTest(char[] input, int n, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.LeastInterval(input, n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}