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
        [DataTestMethod]
        [DataRow(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [DataRow(new[] { 90, 150, 50, 60, 0 }, 60)]
        [DataRow(new[] { 1, 150, 50, 60, 1000 }, 999)]
        [DataRow(new[] { 1, 1, 1, 1, 1 }, 0)]
        [DataRow(new[] { 7, 6, 4, 3, 1}, 0)]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, 4)]

        public void MaxProfitTest(int[] input, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.MaxProfit(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}