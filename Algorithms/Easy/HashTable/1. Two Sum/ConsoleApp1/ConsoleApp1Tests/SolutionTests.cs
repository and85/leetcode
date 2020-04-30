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
        [TestMethod()]
        public void TwoSumTest1()
        {
            // arrange
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            // act
            var solution = new Solution();
            int[] actual = solution.TwoSum(nums, target);

            // assert
            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(1, actual[1]);

        }

        [TestMethod()]
        public void TwoSumTest2()
        {
            // arrange
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;

            // act
            var solution = new Solution();
            int[] actual = solution.TwoSum(nums, target);

            // assert
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(2, actual[1]);

        }

        [TestMethod()]
        public void TwoSumTest3()
        {
            // arrange
            int[] nums = new int[] { 3, 3};
            int target = 6;

            // act
            var solution = new Solution();
            int[] actual = solution.TwoSum(nums, target);

            // assert
            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(1, actual[1]);
        }

        [TestMethod()]
        public void TwoSumTest4()
        {
            // arrange
            int[] nums = new int[] { -3, 4, 3, 90 };
            int target = 0;

            // act
            var solution = new Solution();
            int[] actual = solution.TwoSum(nums, target);

            // assert
            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(2, actual[1]);
        }
    }
}