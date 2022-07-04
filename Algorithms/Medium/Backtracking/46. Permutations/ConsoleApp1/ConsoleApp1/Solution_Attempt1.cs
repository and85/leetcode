using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_Attempt1
    {
        private int _lenght;
        private int[] _nums;

        private IList<IList<int>> _result = new List<IList<int>>();

        public IList<IList<int>> Permute(int[] nums)
        {
            _nums = nums;
            _lenght = nums.Length;
            
            Backtrack(0, new List<int>());

            return _result;
        }

        private void Backtrack(int first, List<int> currentSolution)
        {
            if (currentSolution.Count == _lenght)
                _result.Add(new List<int>(currentSolution));

            for (int i = 0; i < _lenght; i++)
            {
                if (currentSolution.Contains(_nums[i]))
                    continue;

                currentSolution.Add(_nums[i]);

                Backtrack(i, currentSolution);

                currentSolution.RemoveAt(currentSolution.Count - 1);
            }
        }
    }
}
