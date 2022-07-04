using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_Attempt1
    {
        private int _n;
        private int _k;

        private IList<IList<int>> _result = new List<IList<int>>();

        public IList<IList<int>> Combine(int n, int k)
        {
            _n = n;
            _k = k;

            Backtrack(1, new List<int>());
            return _result;
        }

        private void Backtrack(int first, List<int> currentSolution)
        {
            if (currentSolution.Count == _k)
                _result.Add(new List<int>(currentSolution));

            for (int i = first; i <= _n; ++i)
            {
                // add i into the current combination
                currentSolution.Add(i);

                // use next integers to complete the combination
                Backtrack(i + 1, currentSolution);

                // backtrack
                currentSolution.RemoveAt(currentSolution.Count - 1);

            }
        }
    }
}