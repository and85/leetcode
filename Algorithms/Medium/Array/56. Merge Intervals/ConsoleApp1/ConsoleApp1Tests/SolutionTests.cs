using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        public void MergeTest1()
        {
            // arrange
            int[][] intervals = new int[4][]
            {
                new int[] {1, 3 },
                new int[] {2, 6 },
                new int[] {8, 10 },
                new int[] {15, 18 }
            };
            int[][] expected = new int[3][]
            {
                new int[] {1, 6 },
                new int[] {8, 10 },
                new int[] {15, 18 },
            };

            // act
            var solution = new Solution();
            var actual = solution.Merge(intervals);

            // assert
            CollectionAssert.AreEqual(expected, actual, StructuralComparisons.StructuralComparer);
        }

        [DataTestMethod()]
        public void MergeTest2()
        {
            // arrange
            int[][] intervals = new int[2][]
            {
                new int[] {1, 4 },
                new int[] {4, 5 }
            };
            int[][] expected = new int[1][]
            {
                new int[] {1, 5 }
            };

            // act
            var solution = new Solution();
            var actual = solution.Merge(intervals);

            // assert
            CollectionAssert.AreEqual(expected, actual, StructuralComparisons.StructuralComparer);
        }

        [DataTestMethod()]
        public void MergeTest3()
        {
            // arrange
            int[][] intervals = new int[2][]
            {
                new int[] {1, 4 },
                new int[] {0, 4 }
            };
            int[][] expected = new int[1][]
            {
                new int[] {0, 4 }
            };

            // act
            var solution = new Solution();
            var actual = solution.Merge(intervals);

            // assert
            CollectionAssert.AreEqual(expected, actual, StructuralComparisons.StructuralComparer);
        }

        [DataTestMethod()]
        public void MergeTest4()
        {
            // arrange
            int[][] intervals = new int[5][]
            {
                new int[] {2, 3 },
                new int[] {4, 5 },
                new int[] {6, 7 },
                new int[] {8, 9 },
                new int[] {1, 10 }

            };
            int[][] expected = new int[1][]
            {
                new int[] {1, 10 }
            };

            // act
            var solution = new Solution();
            var actual = solution.Merge(intervals);

            // assert
            CollectionAssert.AreEqual(expected, actual, StructuralComparisons.StructuralComparer);
        }
    }
}