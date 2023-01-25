public class Solution 
{
    public int SumNumbers(TreeNode root) 
    {
        return Dfs(root, "");
    }

    private int Dfs(TreeNode root, string prev)
    {
        int sum = 0;
        if (root == null) return sum;
        
        if (root.left == null && root.right == null)
        {
            sum += int.Parse(prev + root.val);
            return sum;
        }

        return Dfs(root.left, prev + root.val ) + Dfs(root.right, prev  + root.val);
    }
}