public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        
        ListNode prev = null, prevLeft = null, firstLeft = null, next, dummyHead = new ListNode();
        
        dummyHead.next = head;

        int currIndex = 0;
        var curr = dummyHead;

        while (curr != null)
        {
            next = curr.next;

            if (currIndex == left)
            {
                prevLeft = prev;
                firstLeft = curr;
            }
                        
            if (currIndex > left && currIndex <= right)
            {
                curr.next = prev;

                if (currIndex == right)
                {
                    if (prevLeft != null)
                        prevLeft.next = curr;
                    if (firstLeft != null)
                        firstLeft.next = next;
                }
                
            }

            prev = curr;
            currIndex++;
            curr = next;
        }

        return dummyHead.next;
    }
}