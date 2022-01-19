package com.company;

public class Solution {
    public int rob(int[] nums) {
        if (nums.length == 1)
            return nums[0];

        int max1, max2;
        max1 = startFromFirstHouse(nums);
        max2 = startFromSecondHouse(nums);

        return Math.max(max1, max2);
    }

    private int startFromFirstHouse(int[] nums) {
        int[] houses = new int[nums.length - 1];
        System.arraycopy(nums, 0, houses, 0, nums.length - 1);
        if (houses.length == 1) return houses[0];

        houses[1] = 0;

        int[] dp = new int[houses.length + 1];
        dp[0] = 0;
        dp[1] = houses[0];

        for (int i = 1; i < houses.length; i++)
        {
            dp[i + 1] = Math.max(houses[i] + dp[i - 1], dp[i]);
        }

        return dp[houses.length];
    }

    private int startFromSecondHouse(int[] nums) {
        int[] houses = new int[nums.length - 1];
        System.arraycopy(nums, 1, houses, 0, nums.length - 1);

        if (houses.length == 1) return houses[0];

        int[] dp = new int[houses.length + 1];
        dp[0] = 0;
        dp[1] = houses[0];

        for (int i = 1; i < houses.length; i++)
        {
            dp[i + 1] = Math.max(houses[i] + dp[i - 1], dp[i]);
        }

        return dp[houses.length];
    }


}
