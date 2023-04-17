public class Solution {
    public IList<int> MajorityElement(int[] nums) 
    {
        int n = nums.Length / 3;

        var dict = nums.GroupBy(i => i).ToDictionary(i => i.Key, i => i.Count());

        var result = new List<int>();
        foreach (var d in dict)
        {
            if (d.Value > n)
            {
                result.Add(d.Key);
            }
        }

        return result;
    }
}