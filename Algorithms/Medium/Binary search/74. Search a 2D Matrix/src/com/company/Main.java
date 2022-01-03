package com.company;

public class Main {

    public static void main(String[] args) {
	    // write your code here
        Solution s = new Solution();
        s.searchMatrix(new int[][] {
                new int[] {1,3,5,7},
                new int[] {10,11,16,20},
                new int[] {23,30,34,60}
        }, 60);
    }

    static class Solution {
        public boolean searchMatrix(int[][] matrix, int target) {
            int row = FindRow(matrix, target);
            if (row == -1) return false;
            int col = FindColum(matrix[row], target);

            return col > -1;
        }

        private int FindColum(int[] row, int target) {
            int l = 0, h = row.length - 1, m;

            while (l <= h) {
                m = l + (h - l) / 2;

                if (target == row[m])
                    return m;
                else if (target > row[m])
                    l = m + 1;
                else if (target < row[m])
                    h = m - 1;
            }

            return -1;
        }

        private int FindRow(int[][] matrix, int target) {
            int width = matrix[0].length;
            int l = 0, h = matrix.length - 1, m;

            while (l <= h) {
                m = l + (h - l) / 2;

                if (target >= matrix[m][0] && target <= matrix[m][width - 1])
                    return m;
                else if (target > matrix[m][width - 1])
                    l = m + 1;
                else if (target < matrix[m][0])
                    h = m - 1;
            }

            return -1;
        }
    }
}
