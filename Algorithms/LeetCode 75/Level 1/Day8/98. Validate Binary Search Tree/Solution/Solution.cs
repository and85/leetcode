public class Solution {

    private List<int> _vertexes = new List<int>();

    public bool IsValidBST(TreeNode root) 
    {
        //InOrderTraversal_Recursive(root);        
        InOrderTraversal_Iterative(root);

        for (int i = 1; i < _vertexes.Count; i++)
        {
            if (_vertexes[i] <= _vertexes[i - 1]) return false;
        }

        return true;
    }

    private void InOrderTraversal_Iterative(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var curr = root;


        while (curr != null || stack.Count > 0)
        {            

            while (curr != null)
            {                
                stack.Push(curr);
                curr = curr.left;
            }

            curr = stack.Pop();
            _vertexes.Add(curr.val);

            curr = curr.right;
        }
    }

    private void InOrderTraversal_Recursive(TreeNode root)
    {
        if (root.left != null)
        {
            InOrderTraversal_Recursive(root.left);
        }

        _vertexes.Add(root.val);

        if (root.right != null)
        {
            InOrderTraversal_Recursive(root.right);
        }        
    }
}