using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;
            foreach (char move in moves)
            {
                switch (move)
                {
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                }
            }

            return (x == 0 && y == 0);
        }
    }
}
