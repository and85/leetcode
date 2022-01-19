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
        [DataTestMethod()]        
        [DataRow(new int[] { 1, 2, 3, 1 }, 2)]
        [DataRow(new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5)]
        [DataRow(new int[] { 2, 1 }, 0)]
        [DataRow(new int[] { 1, 2 }, 1)]
        [DataRow(new int[] { -2147483647, -2147483648 }, 0)]
        [DataRow(new int[] { 3, 2, 1 }, 0)]        
        [DataRow(new int[] { 1, 2, 3 }, 2)]
        public void FindPeakElementTest(int[] nums, int expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.FindPeakElement(nums);

            // assert 
            Assert.AreEqual(expected, actual);
        }
    }
}