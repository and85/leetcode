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
        [DataRow(new int[] { -1, 0, 1, 1, 0, 0, 0, 0, 0 },
            new int[] { -1, 0, 2, 2, 3 },
            4, 5,
            new int[] { -1, -1, 0, 0, 1, 1, 2, 2, 3 })]
        [DataRow(new int[] { 4, 5, 6, 0, 0, 0 },
            new int[] { 1, 2, 3 },
            3, 3,
            new int[] { 1, 2, 3, 4, 5, 6 })]
        [DataRow(new int[] { 1, 2, 3, 0, 0, 0 },
            new int[] { 2, 5, 6 },
            3, 3,
            new int[] { 1, 2, 2, 3, 5, 6 })]
        [DataRow(new int[] { 1 },
            new int[] { 1 },
            1, 0,
            new int[] { 1 })]
        public void MergeTest(int[] nums1, int[] nums2, int m, int n, int[] expected)
        {
            // arrange
            var solution = new Solution();

            // act
            solution.Merge(nums1, m, nums2, n);

            // assert
            CollectionAssert.AreEqual(nums1, expected);
        }
    }
}