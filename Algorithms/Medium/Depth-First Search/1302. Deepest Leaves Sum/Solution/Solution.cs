public class Solution
{
    private int _maxDepth = 0;

    //private List<(int, int)> _leaves = new List<(int, int)>();
    private int _candidateSum = 0;

    public int DeepestLeavesSum(TreeNode root)
    {
        Dfs(root, 0);
        return _candidateSum;
        //return _leaves.Where(x => x.Item2 == _maxDepth).Sum(x => x.Item1);
    }

    private void Dfs(TreeNode root, int depth)
    {
        if (root == null) return;

        if (root.left == null && root.right == null)
        {
            if (depth > _maxDepth)
            {
                _maxDepth = depth;
                _candidateSum = 0;
            }
            
            if (depth == _maxDepth)
            {
                //_leaves.Add((root.val, depth));
                _candidateSum += root.val;
            }
        }

        Dfs(root.left, depth + 1);
        Dfs(root.right, depth + 1);
    }
}