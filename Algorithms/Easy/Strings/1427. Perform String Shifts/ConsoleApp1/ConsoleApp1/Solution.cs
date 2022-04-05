using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string StringShift(string s, int[][] shift)
        {
            StringBuilder sb = new StringBuilder(s);

            foreach (int[] move in shift)
            {
                int length = move[1];
                
                if (move[0] == 0)
                {
                    // left
                    for (int i = 0; i < length; i++)
                    {
                        char t = sb[0];
                        sb.Remove(0, 1);
                        sb.Append(t);
                    }
                    
                }
                else
                {
                    // right
                    for (int i = 0; i < length; i++)
                    {
                        char t = sb[sb.Length - 1];
                        sb.Remove(sb.Length - 1, 1);
                        sb.Insert(0, t);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
