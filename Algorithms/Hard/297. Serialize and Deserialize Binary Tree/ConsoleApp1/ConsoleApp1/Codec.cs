using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp1
{
    public class Codec
    {
        private StringBuilder PreorderTraversal(TreeNode root)
        {
            var result = new StringBuilder();

            //if (root != null)
            //{
            //    result.Append(root.val + ",");
            //    result.Append(PreorderTraversal(root.left));
            //    result.Append(PreorderTraversal(root.right));
            //}
            //else
            //{
            //    result.Append("null,");
            //}
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    result.Append("null,");
                    continue;
                }

                result.Append(node.val + ",");

                stack.Push(node.right);
                stack.Push(node.left);
            }

            return result;
        }

        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var traversedNodes = PreorderTraversal(root);

            var memoryStream = new System.IO.MemoryStream();
            var b = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            b.Serialize(memoryStream, traversedNodes);
            memoryStream.Close();

            return GetString(memoryStream.GetBuffer());
        }

        public TreeNode ReadDeserialized(List<string> l)
        {
            if (l[0].Equals("null"))
            {
                l.RemoveAt(0);
                return null;
            }

            TreeNode root = new TreeNode(int.Parse(l[0]));
            l.RemoveAt(0);
            root.left = ReadDeserialized(l);
            root.right = ReadDeserialized(l);

            return root;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var bytes = GetBytes(data);
            var memoryStream = new System.IO.MemoryStream(bytes);

            var b = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var deserialized = ((StringBuilder)b.Deserialize(memoryStream)).ToString();

            string[] dataArray = deserialized.Split(',');
            var root = ReadDeserialized(dataArray.ToList());

            return root;
        }
    }
}
