var n2 = new TreeNode(2);
var n3 = new TreeNode(3);
var n5 = new TreeNode(5);
var n8 = new TreeNode(8);
var n13 = new TreeNode(13);
var n21 = new TreeNode(21);
var n34 = new TreeNode(34);

n2.left = n3;
n2.right = n5;
n3.left = n8;
n3.right = n13;
n5.left = n21;
n5.right = n34;

var s = new Solution();
s.ReverseOddLevels(n2);