package com.company;

import java.util.Arrays;
import java.util.LinkedList;

public class Solution {
    public void rotate(int[] nums, int k) {
        k = k % nums.length;

        if (k == 0) return;
        if (k == 0) return;

        int[] rotaded = new int[nums.length];

        for (int i = 0; i < nums.length; i++)
        {
            if (i <= nums.length - k - 1)
                rotaded[i + k] = nums[i];
            else
                rotaded[i - nums.length + k] = nums[i];
        }

        nums = Arrays.copyOf(rotaded, nums.length);
        System.arraycopy(rotaded, 0, nums, 0, rotaded.length);
    }

}