public class Solution {
    public bool IsPalindrome(ListNode head) {
        var slow = head;
        var fast = head.next;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next?.next;
        }

        var last = Reverse(slow);

        var ch = head; 
        var cl = last;

        while (ch !=null && cl != null)
        {
            if (ch.val != null && cl.val == null) return false;
            if (cl.val != null && ch.val == null) return false;

            if (ch.val != cl.val) return false;

            ch = ch.next;
            cl = cl.next;
        }

        return true;
    }

    private ListNode Reverse(ListNode head)
    {
        var curr = head;
        ListNode prev = null;

        while (curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;

        }

        return prev;
    }
}