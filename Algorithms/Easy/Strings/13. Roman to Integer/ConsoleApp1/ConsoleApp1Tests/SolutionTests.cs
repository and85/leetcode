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
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("IX", 9)]
        [DataRow("LVIII", 58)]
        [DataRow("MCMXCIV", 1994)]
        public void RomanToIntTest(string input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.RomanToInt(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}