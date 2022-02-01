public class Solution
{
    public void SortColors(int[] nums)
    {
        int curr = 0, p0 = 0, p2 = nums.Length - 1;

        while (curr <= p2)
        {
            if (nums[curr] == 0)
            {
                Swap(nums, curr, p0);                
                curr++;
                p0++;
            }
            else if (nums[curr] == 1)
            {
                curr++;
            }
            else if (nums[curr] == 2)
            {
                Swap(nums, curr, p2);
                p2--;
            }                        
            
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        int t = nums[i];
        nums[i] = nums[j];
        nums[j] = t;
    }
}