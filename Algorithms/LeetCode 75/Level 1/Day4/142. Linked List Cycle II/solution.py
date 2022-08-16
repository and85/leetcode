# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution(object):
    def detectCycle(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """
        # move fast and slow pointers, if they meet, there is a cycle
        # move two slow pointers, one from the point where slow and fast pointers met, the other one from the Head
        # point where two slow pointers meet, is the point we are looking for
        print("start")
        slow = head
        fast = head
        meetPoint = None

        while (fast and fast.next):
            slow = slow.next
            fast = fast.next.next
            
            if (slow == fast):
                meetPoint = slow            
                break                    
            
        if (not meetPoint):
            return None
        
        s1 = head
        s2 = meetPoint        
        while (s1 != s2):
            s1 = s1.next
            s2 = s2.next
        
        return s1
        