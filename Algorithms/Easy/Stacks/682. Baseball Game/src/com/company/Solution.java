package com.company;

import java.util.Stack;

class Solution {
    public int calPoints(String[] ops) {
        int res = 0;
        Stack<Integer> stack = new Stack<Integer>();

        for (String c: ops) {
            switch (c) {
                case "C": {
                    stack.pop();
                }
                break;
                case "D": {
                    int o1 = stack.pop();
                    stack.push(o1);
                    stack.push(o1 * 2);
                }
                break;
                case "+": {
                    int o2 = stack.pop();
                    int o1 = stack.pop();
                    stack.push(o1);
                    stack.push(o2);
                    stack.push(o1 + o2);
                }
                break;

                default: {
                    stack.push(Integer.parseInt(c));
                }
            }
        }

        while (!stack.isEmpty()) {
            res += stack.pop();
        }

        return res;
    }
}
