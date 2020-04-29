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
        public void IsSameTreeTest1()
        {
            // arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            // act
            var solution = new Solution();
            var actual = solution.IsSameTree(root, root);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsSameTreeTest2()
        {
            // arrange
            TreeNode treeOne = new TreeNode(1);
            treeOne.left = new TreeNode(2);
            TreeNode treeTwo = new TreeNode(1);
            treeTwo.right = new TreeNode(2);

            // act
            var solution = new Solution();
            var actual = solution.IsSameTree(treeOne, treeTwo);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsSameTreeTest3()
        {
            // arrange
            TreeNode treeOne = new TreeNode(1);
            treeOne.left = new TreeNode(2);
            treeOne.right = new TreeNode(1);

            TreeNode treeTwo = new TreeNode(1);
            treeTwo.left = new TreeNode(1);
            treeTwo.right = new TreeNode(2);

            // act
            var solution = new Solution();
            var actual = solution.IsSameTree(treeOne, treeTwo);

            // assert
            Assert.IsFalse(actual);
        }
    }
}