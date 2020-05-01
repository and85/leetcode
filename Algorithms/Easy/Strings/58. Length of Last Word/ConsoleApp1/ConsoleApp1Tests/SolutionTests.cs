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
        [DataRow("Hello World", 5)]
        [DataRow("a", 1)]
        [DataRow("a ", 1)]
        public void LengthOfLastWordTest(string input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.LengthOfLastWord(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}