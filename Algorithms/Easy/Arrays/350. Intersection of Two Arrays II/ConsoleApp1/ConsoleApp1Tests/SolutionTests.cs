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
        [DataTestMethod()]
        [DataRow(new int[] { 1, 2, 2, 1 }, 
            new int[] { 2, 2 }, 
            new int[] { 2, 2 })]
        [DataRow(new int[] { 4, 9, 5 },
            new int[] { 9, 4, 9, 8, 4 },
            new int[] { 4, 9 })]
        public void IntersectTest1(int[] nums1, int[] nums2, int[] expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int[] actual = solution.Intersect(nums1, nums2);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}