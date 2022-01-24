var root = new TreeNode(1);
var n1 = new TreeNode(0);
var n2 = new TreeNode(2);
var n3 = new TreeNode(3);
root.left = n1;
root.right = n2;
n2.right = n3;

Codec ser = new Codec();
Codec deser = new Codec();
String tree = ser.serialize(root);
TreeNode ans = deser.deserialize(tree);