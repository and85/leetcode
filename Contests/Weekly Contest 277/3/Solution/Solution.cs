using System.Linq;
public class Solution {
    public IList<int> FindLonely(int[] nums) {
        var result = new List<int>();
        var dict = nums.GroupBy(n => n).Select(n => n).ToDictionary(n => n.Key, n => n.Count());

        foreach (var d in dict)
        {
            if (d.Value > 1) continue;
            if (dict.ContainsKey(d.Key + 1) || dict.ContainsKey(d.Key - 1)) continue;
            result.Add(d.Key);
        }

        return result;
    }
}