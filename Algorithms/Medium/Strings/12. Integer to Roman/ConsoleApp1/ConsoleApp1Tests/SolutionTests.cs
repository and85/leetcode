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
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(9, "IX")]
        [DataRow(58, "LVIII")]
        [DataRow(1994, "MCMXCIV")]
        [DataRow(80, "LXXX")]
        [DataRow(959, "CMLIX")]
        public void IntToRomanTest(int num, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.IntToRoman(num);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}