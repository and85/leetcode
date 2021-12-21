package com.company;

public class Main {

    public static void main(String[] args) {
	    Solution s = new Solution();
	    s.orangesRotting(new int[][] {
	            new int[] { 2,1,1 },
                new int[] { 1,1,0 },
                new int[] { 0,1,1 },
        });

        s.orangesRotting(new int[][] {
                new int[] { 2,1,1 },
                new int[] { 0,1,1 },
                new int[] { 1,0,1 },
        });

        s.orangesRotting(new int[][] {
                new int[] { 0,2 }

        });
    }
}

