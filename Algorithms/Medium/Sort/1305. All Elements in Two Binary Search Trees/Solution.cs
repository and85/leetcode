using System.Collections.Generic;

public class Solution {
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        var queue = new PriorityQueue<int, int>();

        Bfs(root1, queue);
        Bfs(root2, queue);

        var list = new List<int>();
        while (queue.Count > 0)
        {
            list.Add(queue.Dequeue());
        }
        
        return list;
    }

    private void Bfs(TreeNode root, PriorityQueue<int, int> priorityQueue)
    {
        if (root == null) return;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            priorityQueue.Enqueue(node.val, node.val);

            if (node.left != null)
                queue.Enqueue(node.left);
            if (node.right != null)
                queue.Enqueue(node.right);
        }
    }
}