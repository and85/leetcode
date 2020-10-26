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
        [DataRow("aab", "aba")]
        [DataRow("aaab", "")]
        public void ReorganizeStringTest(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.ReorganizeString(input);

            // asset
            Assert.AreEqual(expected, actual);
        }
    }
}