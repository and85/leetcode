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
        [DataRow(new int[]{2, 2, 1}, 1)]
        [DataRow(new int[] { 4, 1, 2, 1, 2 }, 4)]
        public void SingleNumberTest(int[] nums, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.SingleNumber(nums);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}