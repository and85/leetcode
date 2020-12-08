using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // taken from the solution
    public class Solution
    {
        int post_idx;
        int[] postorder;
        int[] inorder;
        Dictionary<int, int> idx_map = new Dictionary<int, int>();

        public TreeNode helper(int in_left, int in_right)
        {
            // if there is no elements to construct subtrees
            if (in_left > in_right)
                return null;

            // pick up post_idx element as a root
            int root_val = postorder[post_idx];
            TreeNode root = new TreeNode(root_val);

            // root splits inorder list
            // into left and right subtrees
            int index = idx_map[root_val];

            // recursion 
            post_idx--;
            // build right subtree
            root.right = helper(index + 1, in_right);
            // build left subtree
            root.left = helper(in_left, index - 1);
            return root;
        }

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            idx_map.Clear();

            this.postorder = postorder;
            this.inorder = inorder;
            // start from the last postorder element
            post_idx = postorder.Length - 1;

            // build a hashmap value -> its index
            for (int i = 0; i < inorder.Length; i++)
                idx_map.Add(inorder[i], i);

            return helper(0, inorder.Length - 1);
        }
    }
}
