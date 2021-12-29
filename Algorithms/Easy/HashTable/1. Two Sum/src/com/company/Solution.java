package com.company;

import java.util.HashMap;

class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();

        for (int i = 0; i < nums.length; i++) {
            int firstKey = target - nums[i];
            if (map.containsKey(firstKey))
                return new int[] {map.get(firstKey), i};

            map.put(nums[i], i);
        }


        return null;
    }
}
