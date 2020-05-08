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
        public void SumOfLeftLeavesTest()
        {
            // arrange
            /*
               3
              / \
              9  20
                /  \
               15   7
            */
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var solution = new Solution();

            // act
            int actual = solution.SumOfLeftLeaves(root);

            // assert
            Assert.AreEqual(24, actual);
        }
    }
}