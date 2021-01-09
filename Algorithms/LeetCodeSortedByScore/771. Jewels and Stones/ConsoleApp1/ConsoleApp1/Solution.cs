using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var jSet = new HashSet<char>(jewels.ToCharArray());
            return stones.Count(s => jSet.Contains(s));
        }
    }
}
