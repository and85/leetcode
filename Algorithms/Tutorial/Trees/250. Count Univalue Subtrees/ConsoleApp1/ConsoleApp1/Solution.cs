using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int CountUnivalSubtrees(TreeNode root)
        {
            if (root == null)
                return 0;

            int count = IsUniSubtree(root) 
                + CountUnivalSubtrees(root.left) 
                + CountUnivalSubtrees(root.right);

            return count;
        }

        private int IsUniSubtree(TreeNode root)
        {
            int val = root.val;
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node.val != val)
                    return 0;

                if (node.right != null)
                    stack.Push(node.right);
                if (node.left != null)
                    stack.Push(node.left);
            }

            return 1;
        }
    }
}
