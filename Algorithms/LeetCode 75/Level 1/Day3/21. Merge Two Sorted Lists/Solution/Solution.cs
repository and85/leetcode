public class Solution 
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null) return null;
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        var sentinelHead = new ListNode(0);
        return RecursiveMerge(l1, l2, sentinelHead);
    }

    public ListNode RecursiveMerge(ListNode l1, ListNode l2, ListNode cur)
    {
        if (l1 == null && l2 == null) return null;
        if (l1 == null) return l2;
        if (l2 == null) return l1;        
        
        if (l1.val < l2.val)
        {
            cur.next = l1;
            l1 = l1.next;
            cur = cur.next;
        }
        else if (l1.val >= l2.val)                      
        {
            cur.next = l2;
            l2 = l2.next;
            cur = cur.next;
        }        

        return cur;
    }

    public ListNode MergeTwoLists_Iterative(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null) return null;
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        var sentinelHead = new ListNode(0);
        var cur = sentinelHead;

        while (l1 != null || l2 != null)
        {
            if (l1 == null)
            {
                cur.next = l2;
                break;
            }
            else if (l2 == null)
            {
                cur.next = l1;
                break;
            }
            else if (l1.val < l2.val)
            {
                cur.next = l1;
                l1 = l1.next;
                cur = cur.next;
            }
            else if (l1.val >= l2.val)                      
            {
                cur.next = l2;
                l2 = l2.next;
                cur = cur.next;
            }
        }

        return sentinelHead.next;
    }
}