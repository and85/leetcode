public class Solution {
    public int MinProductSum(int[] nums1, int[] nums2) {
        Array.Sort(nums1);        
        Array.Sort<int>(nums2, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));

        int sum = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            sum += nums1[i] * nums2[i];
        }

        return sum;       
    }
}