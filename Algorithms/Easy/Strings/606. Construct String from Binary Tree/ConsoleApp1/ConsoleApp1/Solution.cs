using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string Tree2str(TreeNode t)
        {
            var sb = new StringBuilder();

            if (t == null)
                return "";

            if (t.left == null && t.right == null)
                sb.Append(t.val);
            else if (t.right == null)
                sb.Append(t.val + "(" + Tree2str(t.left) + ")");
            else 
                sb.Append(t.val + "(" + Tree2str(t.left) + ")(" + Tree2str(t.right) + ")");

            return sb.ToString();
        }
    }
}
