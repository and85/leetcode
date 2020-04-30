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
        [DataRow(2, 2)]
        [DataRow(3, 3)]
        public void ClimbStairsTest(int n, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.ClimbStairs(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}