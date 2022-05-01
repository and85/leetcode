public class Solution
{
    public int RangeSumBST_Attempt1(TreeNode root, int low, int high)
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

    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null) return 0;

        int sum = 0;

        if (root.val >= low && root.val <= high)
        {
            sum += root.val;
            sum += RangeSumBST(root.left, low, high);
            sum += RangeSumBST(root.right, low, high);
        }

        else if (root.val < low)
        {
            sum += RangeSumBST(root.right, low, high);
        }
        else if (root.val > high)
        {
            sum += RangeSumBST(root.left, low, high);
        }

        return sum;
    }
}
