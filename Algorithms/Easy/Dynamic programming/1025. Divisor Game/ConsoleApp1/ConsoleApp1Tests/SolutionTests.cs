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
        [DataRow(2, true)]
        [DataRow(3, false)]
        [DataRow(4, true)]
        public void DivisorGameTest(int n, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.DivisorGame(n);

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}