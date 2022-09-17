public class Solution 
{
    public int[] SmallestSubarrays(int[] nums) 
    {
        int[] result = new int[nums.Length];
        int sum = nums[nums.Length - 1];
        result[nums.Length - 1] = 1;

        int localSum;
        int counter;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            /*
            sum |= nums[i];

            localSum = nums[i];
            counter = 0;
            for (int j = i; j < nums.Length; j++)
            {
                counter++;
                localSum |= nums[j];
                if (localSum == sum)
                {
                    result[i] = counter;
                    break;
                }
            }
            */
            if ((nums[i] | sum) > sum)
            {
                sum = nums[i] | sum;
                result[i] = result[i + 1];
            }
            else
            {
                result[i] = result[i + 1] + 1;
            }

            
        }

        return result;
    }
}