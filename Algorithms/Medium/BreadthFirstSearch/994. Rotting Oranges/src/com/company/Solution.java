package com.company;

public class Solution {
    public int orangesRotting(int[][] grid) {
        int freshOranges = countFreshOranges(grid);
        int spoiled = 0, prevFresh = freshOranges;

        int minutes = 0;
        while (freshOranges != 0) {
            for (int r = 0; r < grid.length; r++) {
                for (int c = 0; c < grid[r].length; c++) {
                    if (grid[r][c] == 2) {
                        spoiled = spoilNeighbours(grid, r, c);
                        freshOranges -= spoiled;
                    }
                }
            }

            fixGrid(grid);

            if (prevFresh == freshOranges) return -1;

            prevFresh = freshOranges;
            minutes++;
        }

        return minutes;
    }

    private void fixGrid(int[][] grid) {
        for (int r = 0; r < grid.length; r++) {
            for (int c = 0; c < grid[r].length; c++) {
                if (grid[r][c] == -2) grid[r][c] = 2;
            }
        }
    }

    private int spoilNeighbours(int[][] grid, int r, int c) {
        int spoiled = 0;
        if (r > 0 && grid[r - 1][c] == 1) {
            grid[r - 1][c] = -2;
            spoiled++;
        }

        if (r < grid.length - 1 && grid[r + 1][c] == 1) {
            grid[r + 1][c] = -2;
            spoiled++;
        }

        if (c > 0 && grid[r][c - 1] == 1) {
            grid[r][c - 1] = -2;
            spoiled++;
        }

        if (c < grid[r].length - 1 && grid[r][c + 1] == 1) {
            grid[r][c + 1] = -2;
            spoiled++;
        }

        return spoiled;
    }

    private int countFreshOranges(int[][] grid) {
        int res = 0;
        for (int r = 0; r < grid.length; r++) {
            for (int c = 0; c < grid[r].length; c++) {
                if (grid[r][c] == 1)
                    res++;
            }
        }

        return res;
    }
}
