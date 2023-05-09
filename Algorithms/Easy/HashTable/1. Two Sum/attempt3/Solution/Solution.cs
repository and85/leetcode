public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var dict = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], new List<int>());
            }
            
            dict[nums[i]].Add(i);            
        }    

        foreach (var d in dict)
        {
            
            int firstCandidateIndex = d.Value.First();
            
            int r = target - d.Key;
            if (dict.ContainsKey(r))
            {
                foreach (var i in dict[r])
                {
                    if (i == firstCandidateIndex) continue;
                    return new int[] {firstCandidateIndex, i};
                }
            }
        }

        return null;
    }
}