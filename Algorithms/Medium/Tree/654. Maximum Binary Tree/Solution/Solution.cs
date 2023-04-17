public class Solution {

    private Dictionary<int, int> _map = new Dictionary<int, int>();

    public TreeNode ConstructMaximumBinaryTree(int[] nums) 
    {
        _map = nums.Select((value, index) => new {value, index}).ToDictionary(x => x.value, x => x.index);

        var root = BuildTree(nums, 0, nums.Length - 1);
        return root;
    }

    private TreeNode BuildTree(int[] nums, int left, int right)
    {
        if (!InRange(left, right, nums)) return null;

        (int Value, int Index) max = FindMax(nums, left, right);
        
        var node = new TreeNode(max.Value);
        node.left = BuildTree(nums, left, max.Index - 1);
        node.right = BuildTree(nums, max.Index + 1, right);


        return node;
    }

    private bool InRange(int left, int right, int[] nums)
    {
        return left >= 0 && right >= 0 && left < nums.Length && right < nums.Length && left <= right;
    }

    private (int Value, int Index) FindMax(int[] nums, int left, int right)
    {
        int max = int.MinValue, maxIndex = int.MinValue;

        for (int i = left; i <= right; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                maxIndex = i;
            }
        }

        return (max, maxIndex);
    }
}