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
        [DataRow(19, true)]
        public void IsHappyTest(int input, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act 
            bool actual = solution.IsHappy(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}