public class Solution 
{
    private int[] _nums;
    private int[] _numsCopy;

    public Solution(int[] nums) 
    {
        _nums = nums;
        _numsCopy = nums.ToArray();
    }
    
    public int[] Reset() 
    {
        _nums = _numsCopy.ToArray();
        return _nums;
    }
    
    public int[] Shuffle() 
    {
        // Knuth Shuffle implementation
        int r;
        var random = new Random();
        for (int i = 1; i < _nums.Length; i++)
        {
            r = random.Next(i + 1);
            Swap(i, r);
        }

        return _nums;
    }

    private void Swap(int i, int j)
    {
        int t = _nums[i];
        _nums[i] = _nums[j];
        _nums[j] = t;
    } 
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */