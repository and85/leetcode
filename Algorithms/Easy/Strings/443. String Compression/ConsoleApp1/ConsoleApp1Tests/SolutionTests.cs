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
        [DataRow("aabbccc", "a2b2c3", 6)]
        [DataRow("abbbbbbbbbbbb", "ab12", 4)]
        [DataRow("aaabbaa", "a3b2a2", 6)]
        [DataRow("abc", "abc", 3)]
        [DataRow("aaaaab", "a5b", 3)]
        public void CompressTest1(string input, string expected, int expectedLenght)
        {
            // arrange
            var s = new Solution();
            var array = input.ToCharArray();

            // act 

            var actualLenght = s.Compress(array);

            // assert
            Assert.IsTrue(new string(array).StartsWith(expected));
            Assert.AreEqual(expectedLenght, actualLenght);
        }
    }
}