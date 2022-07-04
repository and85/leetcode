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
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        [DataRow(" ", 1)]
        [DataRow("au", 2)]
        [DataRow("jbpnbwwd", 4)]
        [DataRow("dvdf", 3)]
        public void LengthOfLongestSubstringTest(string input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.LengthOfLongestSubstring(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}