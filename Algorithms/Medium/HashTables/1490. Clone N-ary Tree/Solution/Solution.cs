using System;
using System.Collections;
using System.Collections.Generic;

public class Solution 
{
    public Node CloneTree(Node root) 
    {
        if (root == null)
        {
            return null;
        }

        var dict = new Dictionary<Node, Node>();
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        var rootClone = GetClone(root, dict);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            var clone = GetClone(node, dict);

            foreach (var child in node.children)
            {                
                var childClone = GetClone(child, dict);
                clone.children.Add(childClone);
                queue.Enqueue(child);
            }
        }

        return rootClone;
    }

    private Node GetClone(Node node, Dictionary<Node, Node> dict)
    {
        if (dict.ContainsKey(node))
        {
            return dict[node];
        }

        var clone = new Node(node.val);
        dict.Add(node, clone);
        return clone;
    }
}