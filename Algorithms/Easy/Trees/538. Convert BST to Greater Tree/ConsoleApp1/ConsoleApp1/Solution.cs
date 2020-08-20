using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        TreeNode _newRoot;

        public TreeNode ConvertBST(TreeNode root)
        {
            if (_originalRoot == null)
            {
                CopyBST(root, _originalRoot);
            }
            //if (_originalRoot == null)

            //root.val = root.val + GetGreaterSum(root);
        }

        private void CopyBST(TreeNode root, TreeNode newRoot)
        {

            _originalRoot.left = new TreeNode(root.left.val);
            _originalRoot.right = new TreeNode(root.right.val);
        }
    }
}
