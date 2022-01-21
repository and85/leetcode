public class Solution 
{

    int _sum = 0;

    public int SumRootToLeaf(TreeNode root) 
    {
        GetSum(root, 0);

        return _sum;
    }

    private void GetSum(TreeNode root, int num)
    {
        int sum = AddNode(num, root.val);        
        
        if (root.left == null && root.right == null) 
        {            
            _sum += AddNode(num, root.val);
            return;
        }


        if (root.left != null)
        {
            GetSum(root.left, sum);
        }

        if (root.right != null)
        {
            GetSum(root.right, sum);
        }       
    }

    private int AddNode(int num, int val)
    {
        return (num << 1) | val;
    }
}