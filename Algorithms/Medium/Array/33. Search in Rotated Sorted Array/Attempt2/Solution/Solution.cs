using System;

public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        if (nums.Length == 1) return nums[0] == target ? 0 : -1;

        int rotation = FindRotationPoint(nums);
        
        if (rotation == -1)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        if (InRange(nums, 0, rotation - 1, target))
        {
            return BinarySearch(nums, 0, rotation - 1, target);
        }
        
        if (InRange(nums, rotation, nums.Length - 1, target))
        {
            return BinarySearch(nums, rotation, nums.Length - 1, target);
        }


        return -1;
    }

    private int BinarySearch(int[] nums, int start, int end, int target)
    {
        int l = start, r = end;

        while (l <= r)
        {
            int m = l + (r - l) / 2;            

            if (nums[m] < target)
            {
                l++;
            }
            else if (nums[m] > target)
            {
                r--;
            }
            else
            {
                return m;
            }

        }

        return -1;
    }

    private bool InRange(int[] nums, int start, int end, int value)
    {
        return value >= nums[start] && value <= nums[end];
    }

    private int FindRotationPoint(int[] nums)
    {
        if (nums[0] < nums[nums.Length - 1]) return -1;

        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            
            if (m == l) break;

            if (nums[m] > nums[r])
            {
                l = m;
            }
            else if (nums[m] < nums[l])
            {
                r = m;
            }            

        }

        return r;
    }
}