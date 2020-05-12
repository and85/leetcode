using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        public void CanFinishTest1()
        {
            // arrange
            int numCources = 2;
            int[][] prerequisites = new int[][] 
            {
                new int[] { 1, 0}
            };
            bool expected = true;
            var solution = new Solution();

            // act
            bool actual = solution.CanFinish(numCources, prerequisites);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        public void CanFinishTest2()
        {
            // arrange
            int numCources = 2;
            int[][] prerequisites = new int[][]
            {
                new int[] { 1, 0},
                new int[] { 0, 1}
            };
            bool expected = false;
            var solution = new Solution();

            // act
            bool actual = solution.CanFinish(numCources, prerequisites);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        public void CanFinishTest3()
        {
            // arrange
            int numCources = 3;
            int[][] prerequisites = new int[][]
            {
                new int[] { 1, 0},
                new int[] { 0, 2},
                new int[] { 2, 1}
            };
            bool expected = false;
            var solution = new Solution();

            // act
            bool actual = solution.CanFinish(numCources, prerequisites);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}