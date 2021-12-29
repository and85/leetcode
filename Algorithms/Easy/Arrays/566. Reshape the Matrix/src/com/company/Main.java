package com.company;

public class Main {

    public static void main(String[] args) {
	    int[][] matrix1 = new int[][] {
	        new int[] {1, 2},
            new int[] {3, 4}
        };

	    Solution s = new Solution();
	    s.matrixReshape(matrix1, 1, 4);

		int[][] matrix2 = new int[][] {
				new int[] {1, 2, 3, 4}
		};

		s.matrixReshape(matrix2, 2, 2);

    }
}
