public class Solution
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        int sum = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.val >= low && node.val <= high)
            {
                sum += node.val;
            }

            if (node.val >= low && node.left != null)
            {
                queue.Enqueue(node.left);
            }

            if (node.val < high && node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }

        return sum;
    }
}
