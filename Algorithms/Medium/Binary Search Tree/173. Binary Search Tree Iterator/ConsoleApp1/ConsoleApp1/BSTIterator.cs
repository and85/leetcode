using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BSTIterator
    {
        private Stack<TreeNode> _stack = new Stack<TreeNode>();
        private IEnumerator<TreeNode> _enumeratorNext;

        public BSTIterator(TreeNode root)
        {
            _enumeratorNext = InorderTraversal(root).GetEnumerator();
        }

        public int Next()
        {
            _enumeratorNext.MoveNext();
            return _enumeratorNext.Current.val;
        }

        public bool HasNext()
        {
            return _enumeratorNext.Current == null || _stack.Count > 0;
        }

        public IEnumerable<TreeNode> InorderTraversal(TreeNode root)
        {
            TreeNode curr = root;
            _stack.Push(curr);

            while (_stack.Count > 0)
            {
                while (curr?.left != null)
                {
                    _stack.Push(curr.left);
                    curr = curr.left;
                }

                var node = _stack.Pop();


                if (node?.right != null)
                    _stack.Push(node.right);



                curr = node?.right;

                if (node != null)
                    yield return node;
            }
        }
    }
}
