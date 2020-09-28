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
        [DataRow("internationalization", "i12iz4n", true)]
        [DataRow("apple", "a2e", false)]
        [DataRow("internationalization", "i5a11o1", true)]
        [DataRow("a", "2", false)]
        [DataRow("a", "01", false)]
        [DataRow("hi", "hi1", false)]
        [DataRow("hi", "2i", false)]
        [DataRow("word", "w02d", false)]
        [DataRow("leetcode", "l1e5", true)]
        [DataRow("hi", "1", false)]
        public void ValidWordAbbreviationTest(string word, string abbr, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.ValidWordAbbreviation(word, abbr);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}