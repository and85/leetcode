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
        public void MissingNumberTest()
        {
            // arrange
            int[] nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            // act
            int actual = new Solution().MissingNumber(nums);

            // assert
            Assert.AreEqual(8, actual);
        }
    }
}