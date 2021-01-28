using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BSTIterator_Naive
    {
        private int _current = 0;
        private IList<int> _traversed;

        public BSTIterator_Naive(TreeNode root)
        {
            _traversed = InorderTraversal(root);
        }

        public int Next()
        {
            return _traversed[_current++];
        }

        public bool HasNext()
        {
            return _current < _traversed.Count;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            var stack = new Stack<TreeNode>();

            TreeNode curr = root;
            stack.Push(curr);

            while (stack.Count > 0)
            {
                while (curr?.left != null)
                {
                    stack.Push(curr.left);
                    curr = curr.left;
                }

                var node = stack.Pop();
                if (node != null)
                    result.Add(node.val);

                if (node?.right != null)
                    stack.Push(node.right);
                curr = node?.right;
            }

            return result;
        }
    }
}
