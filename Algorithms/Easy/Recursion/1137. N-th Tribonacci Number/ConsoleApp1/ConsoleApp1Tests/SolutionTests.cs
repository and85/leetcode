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
        [DataRow(4, 4)]
        [DataRow(25, 1389537)]
        public void TribonacciTest(int n, int expected)
        {
            var solution = new Solution();

            // act
            int actual = solution.Tribonacci(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}