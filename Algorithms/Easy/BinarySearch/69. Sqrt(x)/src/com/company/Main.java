package com.company;

public class Main {

    public static void main(String[] args) {
	    var s = new Solution();
	    int r1 = s.mySqrt(4);
        int r2 = s.mySqrt(8);
        int r3 = s.mySqrt(9);
        int r4 = s.mySqrt(2);
        int r5 = s.mySqrt(16);
        int r6 = s.mySqrt(25);
        int r7 = s.mySqrt(30);
        int r8 = s.mySqrt(2147395599);
    }

    static class Solution {
        public int mySqrt(int x) {

            if (x <= 1) return x;

            int res;
            double left = 1, right = x, median, prevMedian = left;

            while (left < right)
            {
                median = left + (right - left) / 2;
                if (median * median > x)
                    right = median - 1;

                if (median * median < x)
                    left = median + 1;

                if (median * median == x)
                    return (int)median;

                if (left * left > x)
                    return (int)(left - 1);

                prevMedian = median;
            }

            return (int)left;
        }
    }
}
