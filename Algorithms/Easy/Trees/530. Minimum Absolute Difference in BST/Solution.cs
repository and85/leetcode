 public class Solution {

    private List<int> _sorted = new List<int>();
    public int GetMinimumDifference(TreeNode root) {

        var min = int.MaxValue;
        InOrder(root);
        for (int i = 1; i < _sorted.Count; i++)
        {
            min = Math.Min(min, Math.Abs(_sorted[i] - _sorted[i - 1]));
        }

        return min;

    }

    private void InOrder(TreeNode root)
    {
        if (root == null) return;

        InOrder(root.left);
        _sorted.Add(root.val);
        InOrder(root.right);
    }
}