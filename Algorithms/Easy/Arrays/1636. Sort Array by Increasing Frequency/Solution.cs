public class Solution 
{
    public int[] FrequencySort(int[] nums) 
    {
        var dict = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        var ordered = dict.OrderBy(d => d.Value).ThenByDescending(d => d.Key);

        int pos = 0;
        foreach (var o in ordered)
        {
            for (int i = 0; i < o.Value; i++)
            {
                nums[pos] = o.Key;
                pos++;
            }
        }

        return nums;
    }
}