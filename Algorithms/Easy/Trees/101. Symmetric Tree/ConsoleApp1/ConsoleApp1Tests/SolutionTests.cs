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
        public void IsSymmetricTest1()
        {
            // arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2, new TreeNode(3), new TreeNode(4));
            root.right = new TreeNode(2, new TreeNode(4), new TreeNode(3));

            var solution = new Solution();

            // act
            bool actual = solution.IsSymmetric(root);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsSymmetricTest2()
        {
            // arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            var solution = new Solution();

            // act
            bool actual = solution.IsSymmetric(root);

            // assert
            Assert.IsTrue(actual);
        }
    }
}