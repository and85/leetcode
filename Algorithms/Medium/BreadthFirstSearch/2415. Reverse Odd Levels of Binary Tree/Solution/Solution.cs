public class Solution
{
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int levelIndex = 0;
        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            TreeNode[] curLevel = new TreeNode[levelSize];
            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                if (levelIndex % 2 == 1)
                {
                    curLevel[i] = node;
                }

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            if (levelIndex % 2 == 1)
            {
                ReverseLevel(curLevel);               
            }

            levelIndex++;
        }

        return root;
    }
 
    private void ReverseLevel(TreeNode[] curLevel)
    {
        int l = 0, r = curLevel.Length - 1;
        while (l < r)
        {
            int t = curLevel[l].val;
            curLevel[l].val = curLevel[r].val;
            curLevel[r].val = t;
            l++;
            r--;
        }
    }
}