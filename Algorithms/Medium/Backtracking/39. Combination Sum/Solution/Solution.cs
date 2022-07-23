public class Solution 
{
    private LinkedList<int> _current = new LinkedList<int>();
    private IList<IList<int>> _result = new List<IList<int>>();

    private int _curSum = 0;
    private int _target;

    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        _target = target;

        Array.Sort(candidates);

        Backtrack(candidates);

        return _result;
    }

    private void Backtrack(int[] candidates)
    {
        if (_curSum == _target)
        {
            _result.Add(_current.ToList());
            return;
        }

        for (int i = 0; i < candidates.Length; i++)
        {
            _current.AddLast(candidates[i]);
            _curSum += candidates[i];

            if (_curSum > _target)
            {
                
            }

            Backtrack(candidates);
        }
    }
}