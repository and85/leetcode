var n5 = new ListNode(5);
var n4 = new ListNode(4);
var n2 = new ListNode(2);
var n1 = new ListNode(1);

n5.next = n4;
n4.next = n2;
n2.next = n1;

var s = new Solution();
s.PairSum(n5);