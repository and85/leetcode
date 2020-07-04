using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            TreeNode node = root;

            while (node != null)
            {
                TreeNode temp = node.right;

                node.right = node.left;
                node.left = null;

                TreeNode mostRight = node.right;
                while (mostRight?.right != null)
                {
                    mostRight = mostRight.right;
                }
                if (mostRight != null)
                    mostRight.right = temp;
                else
                    node.right = temp;

                node = node.right;
            }
        }

        public void FlattenRecursive(TreeNode root)
        {
            if (root == null)
                return;

            //Console.WriteLine(root.val);

            TreeNode left = root.left;
            TreeNode right = root.right;

            root.left = null;
            root.right = left;

            TreeNode mostRight = root.right;
            while (mostRight?.right != null)
            {
                mostRight = mostRight.right;
            }
            if (mostRight != null)
                mostRight.right = right;
            else
                root.right = right;

            FlattenRecursive(root.right);
        }
    }
}
