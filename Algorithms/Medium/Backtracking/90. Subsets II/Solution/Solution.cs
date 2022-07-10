using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{
    private IList<IList<int>> _result = new List<IList<int>>();

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        var result = new List<IList<int>>();            

        var solution = new List<int>();

        Backtrack(nums, 0, solution);

        return _result;
    }

    private void Backtrack(int[] nums, int first, List<int> currentSolution)
    {
        if (!SolutionExists(currentSolution))
        {
            _result.Add(new List<int>(currentSolution));
            //currentSolution.Clear();
            
        }

        for (int i = first; i < nums.Length; ++i)
        {
            currentSolution.Add(nums[i]);

            Backtrack(nums, i + 1, currentSolution);

            currentSolution.RemoveAt(currentSolution.Count - 1);
        }
    }

    public bool SolutionExists(List<int> currentSolution)
    {
        foreach (var s in _result)
        {
            if (Enumerable.SequenceEqual(s.OrderBy(i => i), currentSolution.OrderBy(i => i))) return true;
        }

        return false;
    }
}

