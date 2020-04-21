using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void CheckPossibilityTest1()
        {
            // arrange
            int[] nums = new[] { 4, 2, 3 };

            // act
            bool actual = new Solution().CheckPossibility(nums);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckPossibilityTest2()
        {
            // arrange
            int[] nums = new[] { 4, 2, 1 };

            // act
            bool actual = new Solution().CheckPossibility(nums);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckPossibilityTest3()
        {
            // arrange
            int[] nums = new[] { 3, 4, 2, 3 };

            // act
            bool actual = new Solution().CheckPossibility(nums);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckPossibilityTest4()
        {
            // arrange
            int[] nums = new[] { 3, 2, 3, 2, 4 };

            // act
            bool actual = new Solution().CheckPossibility(nums);

            // assert
            Assert.IsFalse(actual);
        }
    }
}