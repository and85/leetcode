using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private class Trust
        {
            public int TrustCounter { get; set; }
            public int TrustedCounter { get; set; }
        }
        public int FindJudge(int n, int[][] trust)
        {
            if (n == 1) return 1;
            
            var dict = new Dictionary<int, Trust>();
            
            foreach (var pair in trust)
            {
                var tr = pair[0];
                var t = pair[1];

                if (!dict.ContainsKey(tr)) 
                    dict.Add(tr, new Trust());
                
                if (!dict.ContainsKey(t))
                    dict.Add(t, new Trust());

                dict[t].TrustedCounter++;
                dict[tr].TrustCounter++;
            }


            var judge = dict.SingleOrDefault(p => p.Value.TrustCounter == 0 && p.Value.TrustedCounter == n - 1);            
            return judge.Key != 0 ? judge.Key : -1;
        }
    }
}
