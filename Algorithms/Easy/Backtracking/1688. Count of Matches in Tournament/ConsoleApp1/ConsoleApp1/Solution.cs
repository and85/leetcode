using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumberOfMatches(int n)
        {
            int teamsRemain = n;
            int played = 0;
            
            while (teamsRemain != 1)
            {
                if (teamsRemain % 2 == 0)
                {
                    played += teamsRemain / 2;
                    teamsRemain /= 2;
                }
                else
                {
                    played += (teamsRemain - 1) / 2;
                    teamsRemain = teamsRemain / 2 + 1;
                }
            }

            return played;
        }
    }
}
