package com.company;

import java.util.AbstractMap;
import java.util.Map;
import java.util.Stack;

class Solution {

    public int[] findBuildings(int[] heights) {
        Stack<Map.Entry<Integer,Integer>> stack = new Stack<>();

        int lastIndex = heights.length - 1;
        stack.push(new AbstractMap.SimpleEntry<>(lastIndex, heights[lastIndex]));

        for (int i = lastIndex - 1; i >= 0; i--) {
            if (heights[i] > stack.peek().getValue()) {
                stack.push(new AbstractMap.SimpleEntry<>(i, heights[i]));
            }
        }

        int[] res = new int[stack.size()];
        int i = 0;
        while (stack.size() > 0) {
            res[i++] = stack.pop().getKey();
        }

        return res;
    }
}
