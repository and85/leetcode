package com.company;

public class Solution {
    public int rob(int[] nums) {
        int[] dp = new int[nums.length + 2];
        dp[0] = nums[0];
        dp[1] = Math.max(nums[0], nums[1]);


        for (int i = 2; i < nums.length; i++) {
            //идея: грабим только четные или нечетные?

            // todo: this is not correct should I change step to avoid robering nearby houses?
            dp[i] = Math.max(dp[i - 2] + nums[i], dp[i - 1]);
        }

        //dp[dp.length - 2] = nums[0];
        //dp[dp.length - 1] = Math.max(nums[0], nums[1]);

        return 0;
    }
}
