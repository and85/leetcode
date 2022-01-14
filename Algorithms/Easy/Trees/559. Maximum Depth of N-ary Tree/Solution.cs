public class Solution {
    public int MaxDepth(Node root) {
        if (root == null) 
            return 0;
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
		int level = 0;
		
		while (queue.Count > 0)
		{
			level++;
			int count = queue.Count;
			
			for (int i = 0; i < count; i++)
			{
			
				var node = queue.Dequeue();

				foreach (var child in node.children)
				{
					queue.Enqueue(child);
				}
			}
		}

        return level;
    }
}