using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private int[] _nums;
        private int _lenght;

        private IList<IList<int>> _result = new List<IList<int>>();

        public IList<IList<int>> Permute(int[] mums)
        {
            _nums = mums;
            _lenght = _nums.Length;

            Backtrack(0, new List<int>());
            return _result;
        }

        private void Backtrack(int first, List<int> currentSolution)
        {
            if (first == _lenght)
                return;

            currentSolution.Add(_nums[first]);

            if (currentSolution.Count == _lenght)
            {
                _result.Add(new List<int>(currentSolution));
                //return;
            }
            
            for (int i = 0; i < _lenght; ++i)
            {
                if (i == first)
                    continue;

                currentSolution.Add(_nums[i]);
                
                Backtrack(i + 1, currentSolution);

                currentSolution.RemoveAt(currentSolution.Count - 1);
            }
        }
    }
}
