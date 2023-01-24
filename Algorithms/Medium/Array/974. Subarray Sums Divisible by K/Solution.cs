public class Solution {
    public int SubarraysDivByK(int[] nums, int k) 
    {
        int res = 0;
        var prefixSums = new Dictionary<int, int>();
        int prev = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int ps = prev + nums[i];
            
            if (ps % k == 0) 
            {
                res++;
            }
            
            if (!prefixSums.ContainsKey(ps))
            {
                prefixSums.Add(ps, 0);
            }
            prefixSums[ps]++;
            prev = ps;
        }

        //    4,  5,   0,   -2,   -3    1
        //    4   9    9     7     4    5
        //    3  -1   -4    -4    -2    1 

        
        

        return res;
    }
}