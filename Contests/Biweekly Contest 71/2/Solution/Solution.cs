public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        List<int> less = new List<int>();
        List<int> greater = new List<int>();
        List<int> equal = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot)
            {
                less.Add(nums[i]);
            }
            else if (nums[i] > pivot)
            {
                greater.Add(nums[i]);
            }
            else
            {
                equal.Add(pivot);
            }
        }

        less.AddRange(equal);
        less.AddRange(greater);

        return less.ToArray();
    }
}