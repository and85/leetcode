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
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsSymmetricTest3()
        {
            // arrange
            TreeNode root = new TreeNode(1);
            TreeNode node1 = new TreeNode(2);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = null;
            TreeNode node4 = new TreeNode(3);
            TreeNode node5 = null;
            TreeNode node6 = new TreeNode(3);

            root.left = node1;
            root.right = node2;

            node1.left = node3;
            node1.right = node4;
            node2.left = node5;
            node2.right = node6;

            var solution = new Solution();

            // act
            bool actual = solution.IsSymmetric(root);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsSymmetricTest4()
        {
            // arrange
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2, new TreeNode(3), new TreeNode(4));
            root.right = new TreeNode(5, new TreeNode(6), new TreeNode(7));

            var solution = new Solution();

            // act
            bool actual = solution.IsSymmetric(root);

            // assert
            Assert.IsFalse(actual);
        }
    }
}