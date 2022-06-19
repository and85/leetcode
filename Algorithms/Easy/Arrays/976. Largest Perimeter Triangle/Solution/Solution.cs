public class Solution 
{
    public int LargestPerimeter(int[] nums)
    {
        int a = nums[0];
        int b = nums[1];
        int c = nums[2];

        if (a + b > c || a + c > b || b + c > a)
        {
            return a + b + c;
        }

        return 0;        
    }
}