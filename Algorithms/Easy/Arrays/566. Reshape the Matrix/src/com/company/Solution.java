package com.company;

class Solution {
    public int[][] matrixReshape(int[][] mat, int r, int c) {
        int originalSize = mat.length * mat[0].length;
        int newSize = r * c;
        if (originalSize != newSize) return mat;

        int[][] newMatrix = new int[r][c];

        int count = 0;
        for (int row = 0; row < mat.length; row++)
            for (int col = 0; col < mat[row].length; col++) {
                newMatrix[count / c][count % c] = mat[row][col];
                count++;
            }

        return newMatrix;
    }

    public int[][] matrixReshape_FirstApproach(int[][] mat, int r, int c) {
        int originalSize = mat.length * mat[0].length;
        int newSize = r * c;
        if (originalSize != newSize) return mat;

        int[][] newMatrix = new int[r][c];

        int newRow = 0, newCol = 0;
        for (int row = 0; row < mat.length; row++)
            for (int col = 0; col < mat[row].length; col++) {
                newMatrix[newRow][newCol++] = mat[row][col];

                if  (newCol == c) {
                    newCol = 0;
                    newRow++;
                }
            }

        return newMatrix;
    }
}
