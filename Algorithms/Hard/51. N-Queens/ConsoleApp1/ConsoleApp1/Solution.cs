using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private string _emptyLine;

        public IList<IList<string>> SolveNQueens(int n)
        {            
            var result = new List<IList<string>>();

            for (int firstRowPosition = 0; firstRowPosition < n; firstRowPosition++)
            {
                if (Solve(firstRowPosition, n, out var solution))
                    result.Add(solution);
            }

            return result;
        }

        private bool Solve(int firstRowPosition, int n, out List<string> solution)
        {
            var positions = new List<(int, int)>();
            positions.Add((0, firstRowPosition));
            
            solution = new List<string>();
            
            //solution.Add(".Q.Q");
            //solution.Add("Q..Q");            

            for (int r = 1; r < n; r++)
            {
                //if ()
            }


            return true;
        }
    }
}
