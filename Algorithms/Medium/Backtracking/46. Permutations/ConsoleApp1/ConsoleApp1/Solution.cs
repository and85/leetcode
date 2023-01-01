using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private IList<IList<int>> _solution = new List<IList<int>>();
        private HashSet<int> _currentSolution = new HashSet<int>();

        public IList<IList<int>> Permute(int[] nums)
        {

            Backtracking(nums);
            return _solution;

        }

        private void Backtracking(int[] array)
        {
            if (_currentSolution.Count == array.Length) // 3 == 3
            {
                _solution.Add(_currentSolution.ToList()); // (1, 2, 3)
                return;
            }

            for (int i = 0; i < array.Length; i++) // 1
            {
                if (_currentSolution.Contains(array[i])) continue;
                _currentSolution.Add(array[i]); // _current(1, 2, 3)
                Backtracking(array); // i = 2 + 1 
                _currentSolution.Remove(array[i]);
            }
        }
    }
}
