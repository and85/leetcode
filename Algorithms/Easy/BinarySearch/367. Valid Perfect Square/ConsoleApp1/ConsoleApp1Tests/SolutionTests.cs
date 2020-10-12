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
        [DataRow(16, true)]
        [DataRow(14, false)]
        [DataRow(9, true)]
        [DataRow(6, false)]
        [DataRow(5, false)]
        [DataRow(7, false)]
        [DataRow(64, true)]
        [DataRow(2147395600, true)]
        [DataRow(2147483647, false)]
        public void IsPerfectSquareTest(int input, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.IsPerfectSquare(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}