public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head, fast = head?.next;

        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next?.next;
        }

        return slow;
    }
}