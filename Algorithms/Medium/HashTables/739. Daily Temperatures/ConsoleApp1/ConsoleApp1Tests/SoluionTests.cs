using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SoluionTests
    {
        [TestMethod()]
        public void DailyTemperaturesTest1()
        {
            // arrange
            var input = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            var expected = new int[] {1, 1, 4, 2, 1, 1, 0, 0};

            // act
            var solution = new Solution();
            var acual = solution.DailyTemperatures(input);

            // assert
            CollectionAssert.AreEqual(expected, acual);
        }

        [TestMethod()]
        public void DailyTemperaturesTest2()
        {
            // arrange
            var input = new int[] { 89, 62, 70, 58, 47, 47, 46, 76, 100, 70 };
            var expected = new int[] { 8, 1, 5, 4, 3, 2, 1, 1, 0, 0 };

            // act
            var solution = new Solution();
            var acual = solution.DailyTemperatures(input);

            // assert
            CollectionAssert.AreEqual(expected, acual);
        }

        [TestMethod()]
        public void DailyTemperaturesTest3()
        {
            // arrange
            var input = new int[] { 34, 80, 80, 34, 34, 80, 80, 80, 80, 34 };
            var expected = new int[] { 1, 0, 0, 2, 1, 0, 0, 0, 0, 0 };

            // act
            var solution = new Solution();
            var acual = solution.DailyTemperatures(input);

            // assert
            CollectionAssert.AreEqual(expected, acual);
        }

        [TestMethod()]
        public void DailyTemperaturesTest4()
        {
            // arrange
            var input = new int[] { 77, 77, 77, 77, 77, 41, 77, 41, 41, 77 };
            var expected = new int[] { 0, 0, 0, 0, 0, 1, 0, 2, 1, 0 };

            // act
            var solution = new Solution();
            var acual = solution.DailyTemperatures(input);

            // assert
            CollectionAssert.AreEqual(expected, acual);
        }
    }
}
