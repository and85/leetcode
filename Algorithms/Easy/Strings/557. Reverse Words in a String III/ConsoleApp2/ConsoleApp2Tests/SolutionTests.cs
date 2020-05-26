using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        [DataRow("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
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