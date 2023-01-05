/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        TraverseInorder(root);
        return _isValid;
    }

    private int? _prev;
    private bool _isValid = true;

    private void TraverseInorder(TreeNode root)
    {
        if (root == null || !_isValid) return;

        TraverseInorder(root.left);

        if (root.val <= _prev)
        {
            _prev = root.val;
            _isValid = false;
            return;
        }

        _prev = root.val;

        TraverseInorder(root.right);
    }
}



