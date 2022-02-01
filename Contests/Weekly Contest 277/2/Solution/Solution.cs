public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {        
        int[] negatives = new int[nums.Length / 2];
        int[] positives = new int[nums.Length / 2];

        GetArrays(nums, ref negatives, ref positives);

        int n = 0, p = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)       
            {
                nums[i] = positives[p];
                p++;
            }
            else
            {
                nums[i] = negatives[n];
                n++;
            }
        }

        return nums;
    }

    private void GetArrays(int[] nums, ref int[] negatives, ref int[] positives)
    {
        var listNegative = new List<int>();
        var listPositive = new List<int>();

        foreach (var n in nums)
        {
            if (n < 0)
            {
                listNegative.Add(n);                
            }
            else
            {
                listPositive.Add(n);
            }
        }

        negatives = listNegative.ToArray();
        positives = listPositive.ToArray();
    }

    
}