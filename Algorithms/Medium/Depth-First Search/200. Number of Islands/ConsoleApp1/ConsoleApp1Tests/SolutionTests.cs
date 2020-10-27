using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void NumIslandsTest1()
        {
            // arrange
            int expected = 1;
            var grid = new char[][]
            {
                new char[] { '1', '1', '1', '1', '0'},
                new char[] { '1', '1', '0', '1', '0'},
                new char[] { '1',  '1', '0', '0', '0'},
                new char[] { '0',  '0', '0', '0', '0'}
            };


            var solution = new Solution();

            // act
            int actual = solution.NumIslands(grid);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumIslandsTest2()
        {
            // arrange
            int expected = 3;
            var grid = new char[][]
            {
                new char[] { '1', '1', '0', '0', '0'},
                new char[] { '1', '1', '0', '0', '0'},
                new char[] { '0',  '0', '1', '0', '0'},
                new char[] { '0',  '0', '0', '1', '1'}
            };


            var solution = new Solution();

            // act
            int actual = solution.NumIslands(grid);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumIslandsTest3()
        {
            // arrange
            int expected = 1;
            var grid = new char[][]
            {
                new char[] { '1', '1', '1' },
                new char[] { '0', '1', '0' },
                new char[] { '1', '1', '1'}
            };


            var solution = new Solution();

            // act
            int actual = solution.NumIslands(grid);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumIslandsTest4()
        {
            // arrange
            int expected = 1;
            var grid = new char[][]
            {
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '0', '1', '0', '1' },
                new char[] { '1', '1', '1', '0', '1'}
            };


            var solution = new Solution();

            // act
            int actual = solution.NumIslands(grid);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumIslandsTest5()
        {
            // arrange
            int expected = 1;
            var grid = new char[][]
            {
                new char[] { '1' },
                new char[] { '1' }
            };


            var solution = new Solution();

            // act
            int actual = solution.NumIslands(grid);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}