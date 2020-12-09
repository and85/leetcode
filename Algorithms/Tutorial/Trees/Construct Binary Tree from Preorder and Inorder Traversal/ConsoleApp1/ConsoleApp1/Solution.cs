using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _preIndex;
        private int[] _preorder;
        Dictionary<int, int> _inoderMap = new Dictionary<int, int>();

        public TreeNode helper(int in_left, int in_right)
        {
            // if there is no elements to construct subtrees
            if (in_left > in_right)
                return null;

            // pick up post_idx element as a root
            int root_val = _preorder[_preIndex];
            TreeNode root = new TreeNode(root_val);

            // root splits inorder list
            // into left and right subtrees
            int index = _inoderMap[root_val];

            // recursion 
            _preIndex++;
            root.left = helper(in_left, index - 1);
            root.right = helper(index + 1, in_right);
            
            return root;
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            _inoderMap.Clear();

            _preorder = preorder;
            // start from the last postorder element
            _preIndex = 0;

            // build a hashmap value -> its index
            for (int i = 0; i < inorder.Length; i++)
                _inoderMap.Add(inorder[i], i);

            return helper(0, inorder.Length - 1);
        }
    }
}
