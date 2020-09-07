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
        [DataRow("the sky is blue", "blue is sky the")]
        [DataRow("  hello world!  ", "world! hello")]
        [DataRow("a good   example", "example good a")]
        public void ReverseWordsTest(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.ReverseWords(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}