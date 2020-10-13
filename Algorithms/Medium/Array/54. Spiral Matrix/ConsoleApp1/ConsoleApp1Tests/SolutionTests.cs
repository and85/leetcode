using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void SpiralOrderTest1()
        {
            // arrange
            IList<int> expected = new List<int>() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            int[][] matrix = new int[3][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            // act
            var solution = new Solution();
            var actual = solution.SpiralOrder(matrix);

            // assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod()]
        public void SpiralOrderTest2()
        {
            // arrange
            IList<int> expected = new List<int>() { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
            int[][] matrix = new int[3][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 }
            };

            // act
            var solution = new Solution();
            var actual = solution.SpiralOrder(matrix);

            // assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}