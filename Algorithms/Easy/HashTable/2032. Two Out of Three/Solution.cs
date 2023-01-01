public class Solution 
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) 
    {
        var result = new List<int>();
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        var set3 = new HashSet<int>(nums3);

        result.AddRange(set1.Intersect(set2));
        result.AddRange(set2.Intersect(set3));
        result.AddRange(set1.Intersect(set3));

        return result.Distinct().ToList();
    }
}