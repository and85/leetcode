using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private IList<IList<int>> _result = new List<IList<int>>();

        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();            

            var solution = new List<int>();

            Backtrack(nums, 0, solution);

            return _result;
        }

        private void Backtrack(int[] nums, int first, List<int> currentSolution)
        {            
            _result.Add(new List<int>(currentSolution));

            for (int i = first; i < nums.Length; ++i)
            {
                // add nums[i] into the current combination
                currentSolution.Add(nums[i]);

                // use next integers to complete the combination
                Backtrack(nums, i + 1, currentSolution);

                // backtrack
                currentSolution.RemoveAt(currentSolution.Count - 1);
            }
        }
    }
}
