public class Solution {
    public TreeNode InvertTree(TreeNode root) 
    {
        if (root == null) return root;

        var t = root.left;
        root.left = root.right;
        root.right = t;

        if (root.left != null)
            InvertTree(root.left);
        
        if (root.right != null)
            InvertTree(root.right);

        return root;
    }
}