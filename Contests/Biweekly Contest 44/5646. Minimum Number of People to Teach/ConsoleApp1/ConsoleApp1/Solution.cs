using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
        {

            

            int min = int.MaxValue;

            for (int l = 1; l <= n; l++)
            {
                var lh = new HashSet<int>[languages.Length + 1];
                for (int li = 0; li < languages.Length; li++)
                {
                    //languages[l]
                    lh[li + 1] = new HashSet<int>(languages[li]);
                }


                int usersTaught = 0;
                for (int f = 0; f < friendships.Length; f++)
                {
                    usersTaught += CountUsersTaugh(friendships, lh, f, l);
                }

                min = Math.Min(min, usersTaught);
            }

            return min;
        }

        private int CountUsersTaugh(int[][] friendships, HashSet<int>[] languages, int f, int l)
        {
            var l1 = languages[friendships[f][0]];
            var l2 = languages[friendships[f][1]];

            if (SpeakCommonLanguage(l1, l2))
                return 0;

            //if (l1.cont)
            int res = 0;
            if (!l1.Contains(l))
            {
                l1.Add(l);
                res++;
            }

            if (!l2.Contains(l))
            {
                l2.Add(l);
                res++;
            }

            return res;
        }

        private bool SpeakCommonLanguage(HashSet<int> l1, HashSet<int> l2)
        {
            

            foreach (var v in l1)
            {
                if (l2.Contains(v))
                    return true;
            }

            return false;
        }
    }
}
