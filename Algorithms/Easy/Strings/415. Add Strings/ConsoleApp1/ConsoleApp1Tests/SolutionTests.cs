using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        [DataRow("3", "5", "8")]
        [DataRow("2", "9", "11")]
        [DataRow("22", "9", "31")]
        [DataRow("501", "12", "513")]
        public void AddStringsTest(string num1, string num2, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.AddStrings(num1, num2);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}