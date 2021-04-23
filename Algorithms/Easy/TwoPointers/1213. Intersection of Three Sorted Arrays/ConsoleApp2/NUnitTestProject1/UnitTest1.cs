using System;
using System.Collections.Generic;
using System.ComponentModel;
using ConsoleApp2;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5, 7, 9 }, new int[] { 1, 3, 4, 5, 8 })]
        [TestCase(new int[] { 17, 193, 281, 421, 523, 596, 1484, 1803, 1853, 1863 }, 
            new int[] { 381, 770, 1100, 1164, 1211, 1483, 1486, 1639, 1908, 1988 }, 
            new int[] { 107, 290, 291, 546, 751, 896, 967, 1532, 1538, 1784 })]
        public void Test1(int[] arr1, int[] arr2, int[] arr3)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.ArraysIntersection(arr1, arr2, arr3);

            // assert
            var expected = new List<int>() {1, 5};
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}