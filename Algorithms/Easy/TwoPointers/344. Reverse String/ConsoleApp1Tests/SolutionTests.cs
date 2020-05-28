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
        [DataRow("hello", "olleh")]
        [DataRow("Hannah", "hannaH")]
        public void ReverseStringTest(string input, string expected)
        {
            // arrange
            var solution = new Solution();
            char[] charArray = input.ToCharArray();

            // act
             solution.ReverseString(charArray);

            // assert
            Assert.AreEqual(expected, new string(charArray));
        }
    }
}