public class Solution 
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        if (root.val == p.val || root.val == q.val) return root;

        int l = Math.Min(q.val, p.val);
        int r = Math.Max(q.val, p.val);

        if (root.val > l && root.val < r)
            return root;

        if (l < root.val && r < root.val)
            return LowestCommonAncestor(root.left, p, q);

        if (l > root.val && r > root.val)
            return LowestCommonAncestor(root.right, p, q);

        return null;
    }
}