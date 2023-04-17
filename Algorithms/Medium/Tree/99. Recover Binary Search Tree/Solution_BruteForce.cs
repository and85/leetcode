public class Solution_BruteForce 
{
    private List<int> _traversed = new List<int>();
    private int[] _array;
    private int _index;

    public void RecoverTree(TreeNode root) 
    {
        InOrderTraversal(root);

        _array = _traversed.ToArray();
        Array.Sort(_array);

        Rearange(root);
    }

    private void InOrderTraversal(TreeNode root)
    {
        if (root == null) return;

        InOrderTraversal(root.left);
        _traversed.Add(root.val);

        InOrderTraversal(root.right);
    }

    private void Rearange(TreeNode root)
    {
        if (root == null) return;

        Rearange(root.left);
        root.val = _array[_index++];

        Rearange(root.right);
    }
}