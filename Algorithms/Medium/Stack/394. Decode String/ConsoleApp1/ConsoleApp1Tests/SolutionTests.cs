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
        [DataRow("3[a]2[bc]", "aaabcbc")]
        [DataRow("3[a2[c]]", "accaccacc")]
        [DataRow("2[abc]3[cd]ef", "abcabccdcdcdef")]
        [DataRow("abc3[cd]xyz", "abccdcdcdxyz")]
        public void DecodeStringTest(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.DecodeString(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}