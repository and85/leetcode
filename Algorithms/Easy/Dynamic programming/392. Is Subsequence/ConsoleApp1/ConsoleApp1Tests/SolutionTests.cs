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
        [DataRow("abc", "ahbgdc", true)]
        [DataRow("axc", "ahbgdc", false)]
        public void IsSubsequenceTest(string s, string t, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.IsSubsequence(s, t);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}