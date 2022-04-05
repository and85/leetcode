using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindRepeatedDnaSequencesTest()
        {
            // arrange
            string input = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";

            // act
            var solution = new Solution();
            var actual = solution.FindRepeatedDnaSequences(input);

            // assert
            Assert.AreEqual("AAAAACCCCC", actual[0]);
            Assert.AreEqual("CCCCCAAAAA", actual[1]);
        }

        [TestMethod()]
        public void FindRepeatedDnaSequencesTest2()
        {
            // arrangeAAAAAAAAAA
            string input = "AAAAAAAAAAA";

            // act
            var solution = new Solution();
            var actual = solution.FindRepeatedDnaSequences(input);

            // assert
            Assert.AreEqual("AAAAAAAAAA", actual[0]);
        }
    }
}