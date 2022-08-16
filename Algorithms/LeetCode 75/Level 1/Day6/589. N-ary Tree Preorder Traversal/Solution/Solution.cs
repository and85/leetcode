public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var nodes = new List<int>();
        //return PreorderRecursive(root, nodes);            

        if (root == null)
        {
            return new List<int>();
        }

        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            nodes.Add(node.val);

            foreach (var child in node.children.Reverse())
            {
                stack.Push(child);
            }
        }

        return nodes;
    }

    private IList<int> PreorderRecursive(Node root, List<int> nodes)
    {
        if (root == null)
        {
            return nodes;
        }

        nodes.Add(root.val);

        foreach (var c in root.children)
        {
            PreorderRecursive(c, nodes);
        }


        return nodes;
    }    
}