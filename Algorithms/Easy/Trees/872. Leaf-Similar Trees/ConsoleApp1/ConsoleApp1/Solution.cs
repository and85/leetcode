using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var l1 = new List<int>();
            var l2 = new List<int>();
            Dfs(root1, l1);
            Dfs(root2, l2);

            return l1.SequenceEqual(l2);
        }

        private void Dfs(TreeNode root, List<int> l)
        {
            //Recursive(root, l);

            var stack = new Stack<TreeNode>();
            stack.Push(root);
            TreeNode node;

            while (stack.Count != 0)
            {
                node = stack.Pop();
                if (node.left == null && node.right == null)
                {
                    l.Add(node.val);
                    continue;        
                }

                if (node.right != null)
                    stack.Push(node.right);
                if (node.left != null)
                    stack.Push(node.left);
            }
        }

        private void Recursive(TreeNode root, List<int> l)
        {
            if (root == null) return;

            if (root.left == null && root.right == null)
            {
                l.Add(root.val);
                return;
            }

            Dfs(root.left, l);
            Dfs(root.right, l);
        }
    }
}
