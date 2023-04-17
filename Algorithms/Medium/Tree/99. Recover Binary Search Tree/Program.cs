var s = new Solution();
var n1 = new TreeNode(1);
var n2 = new TreeNode(2);
var n3 = new TreeNode(3);
n1.left = n3;
n3.right = n2;

s.RecoverTree(n1);