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
        public void FindDuplicateTest0()
        {
            // arrange
            int[] input = new int[] { 1, 3, 4, 2, 2 };

            // act
            var actual = new Solution().FindDuplicate(input);

            // assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        public void FindDuplicateTest1()
        {
            // arrange
            int[] input = new int[] { 3, 1, 3, 4, 2 };

            // act
            var actual = new Solution().FindDuplicate(input);

            // assert
            Assert.AreEqual(3, actual);
        }

        [TestMethod()]
        public void FindDuplicateTest2()
        {
            // arrange
            int[] input = new int[] { 9, 4, 9, 5, 7, 2, 8, 9, 3, 9 };

            // act
            var actual = new Solution().FindDuplicate(input);

            // assert
            Assert.AreEqual(9, actual);
        }

        [TestMethod()]
        public void FindDuplicateTest3()
        {
            // arrange
            int[] input = new int[] { 4, 3, 1, 4, 2 };

            // act
            var actual = new Solution().FindDuplicate(input);

            // assert
            Assert.AreEqual(4, actual);
        }
    }
}