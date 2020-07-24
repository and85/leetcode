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
        [DataRow("1 + 1", 2)]
        [DataRow(" 2-1 + 2 ", 3)]
        [DataRow("(1+(4+5+2)-3)+(6+8)", 23)]
        public void CalculateTest(string expression, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.Calculate(expression);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}