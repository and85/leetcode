package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Solution s = new Solution();
        boolean res = s.canFinish(5, new int[][] {
                new int[] { 1, 4 },
                new int[] { 2, 4 },
                new int[] { 3, 1 },
                new int[] { 3, 2 },
        });
    }
}
