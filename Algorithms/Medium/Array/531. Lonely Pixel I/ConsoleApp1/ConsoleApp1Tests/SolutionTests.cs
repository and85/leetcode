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
        public void FindLonelyPixelTest1()
        {
            // arrange
            char[][] input = new char[3][] 
            {
                new char[] { 'W', 'W', 'B'},
                new char[] { 'W', 'B', 'W'},
                new char[] { 'B', 'W', 'W'}
            };

            // act
            var solution = new Solution();
            var actual = solution.FindLonelyPixel(input);

            // assert
            Assert.AreEqual(3, actual);
        }

        [TestMethod()]
        public void FindLonelyPixelTest2()
        {
            // arrange
            char[][] input = new char[3][]
            {
                new char[] { 'W', 'W', 'W'},
                new char[] { 'W', 'W', 'W'},
                new char[] { 'W', 'W', 'W'}
            };

            // act
            var solution = new Solution();
            var actual = solution.FindLonelyPixel(input);

            // assert
            Assert.AreEqual(3, actual);
        }

        [TestMethod()]
        public void FindLonelyPixelTest3()
        {
            // arrange
            char[][] input = new char[1][]
            {
                new char[] { 'B', 'B', 'B'}
            };

            // act
            var solution = new Solution();
            var actual = solution.FindLonelyPixel(input);

            // assert
            Assert.AreEqual(0, actual);
        }
    }
}