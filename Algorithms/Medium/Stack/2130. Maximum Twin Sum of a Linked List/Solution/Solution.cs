public class Solution 
{
    public int PairSum(ListNode head) 
    {
        var cur = head;
        var stack = new Stack<ListNode>();

        while (cur != null)
        {
            stack.Push(cur);
            cur = cur.next;
        }

        int n = stack.Count / 2;
        int[] sums = new int[n];

        int pos = 0;
        bool halfReached = false;
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            
            if (pos < n && !halfReached)
            {
                sums[pos] += node.val;
                pos++;
            }
            else
            {
                halfReached = true;
                pos--;        
                sums[pos] += node.val;
            }
            
        }

        return sums.Max();
    }
}