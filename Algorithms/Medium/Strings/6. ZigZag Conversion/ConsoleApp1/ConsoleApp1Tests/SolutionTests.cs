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
        [DataRow("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [DataRow("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [DataRow("AB", 1, "AB")]
        [DataRow("ABC", 1, "ABC")]
        [DataRow("ABCD", 2, "ACBD")]
        public void ConvertTest(string input, int n, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.Convert(input, n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}