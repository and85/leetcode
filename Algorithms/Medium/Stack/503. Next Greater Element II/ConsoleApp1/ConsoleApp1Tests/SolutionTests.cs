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
        [DataRow(new int[] { 1, 2, 1 }, new int[] { 2, -1, 2 })]
        [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { -1, 5, 5, 5, 5 })]
        public void NextGreaterElementsTest(int[] input, int[] expected)
        {
            // arrange
            var solution = new Solution();

            // act
            var actual = solution.NextGreaterElements(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}