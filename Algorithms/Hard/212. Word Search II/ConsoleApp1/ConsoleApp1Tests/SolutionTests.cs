using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindWordsTest()
        {
            // arrange
            var board = new char[4][]
                {
                    new char[] { 'o', 'a', 'a', 'n' },
                    new char[] { 'e', 't', 'a', 'e' },
                    new char[] { 'i', 'h', 'k', 'r' },
                    new char[] { 'i', 'f', 'l', 'v' }
                };
            var words = new string[] { "oath", "pea", "eat", "rain" };
            var expected = new string[] { "eat", "oath" };

            // act
            var solution = new Solution();
            var actual = solution.FindWords(board, words).ToArray();

            // assert
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}