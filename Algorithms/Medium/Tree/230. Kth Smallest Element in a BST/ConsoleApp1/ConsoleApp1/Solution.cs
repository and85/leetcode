using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _k;
        private int _counter;
        private int _res;
        public int KthSmallest(TreeNode root, int k)
        {
            _k = k;
            InodrderTraversal(root);

            return _res;
        }

        private void InodrderTraversal(TreeNode root)
        {
            if (root == null)
                return;

            InodrderTraversal(root.left);

            if (++_counter == _k)
            {
                _res = root.val;
                return;
            }

            InodrderTraversal(root.right);
        }
    }
}
