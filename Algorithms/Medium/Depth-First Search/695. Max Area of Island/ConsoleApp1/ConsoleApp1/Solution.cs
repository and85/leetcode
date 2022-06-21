using System;
using System.Collections.Generic;

public class Solution
{
	private int _height;
	private int _width;
	private int[][] _grid;


	public int MaxAreaOfIsland(int[][] grid)
	{
		int maxArea = 0;
		for (int r = 0; r < grid.Length; r++)
        {
			for (int c = 0; c < grid[r].Length; c++)
            {
				if (grid[r][c] == 1)
                {
					maxArea = Math.Max(maxArea, FindArea(grid, r, c));
                }
            }

		}

		return maxArea;
	}

	private (int, int)[] _directions = new (int, int)[]
	{
		(-1, 0),
		(1, 0),
		(0, -1),
		(0, 1),
		
	};

    private int FindArea(int[][] grid, int r, int c)
    {
		int result = 0;
		var stack = new Stack<(int, int)>();
		stack.Push((r, c));

		while (stack.Count > 0)
        {
			var cell = stack.Pop();
			r = cell.Item1;
			c = cell.Item2;

			if (grid[r][c] != 1) continue;

			result++;			
			grid[r][c] = -1;	

			foreach (var dir in _directions)
            {
				int nr = r + dir.Item1;
				int nc = c + dir.Item2;

				if (InRange(grid, nr, nc))
                {					
					if (grid[nr][nc] == 1)
                    {
						stack.Push((nr, nc));
                    }
				}
            }
        }

		return result;
    }

    private bool InRange(int[][] grid, int r, int c)
    {
        return (r >= 0) && (r < grid.Length) && (c >=0 ) && (c < grid[r].Length);
    }

    public int FindCircleNum(int[][] M)
	{
		_grid = M;
		_height = _grid.Length;
		_width = _grid[0].Length;

		int result = 0;
		for (int r = 0; r < _height; r++)
			for (int c = 0; c < _width; c++)
			{
				if (IsCircleFound(r, c))
				{
					DfsCircle(r, c);
					result++;
				}
			}

		return result;
	}
	
	private bool IsCircleFound(int r, int c)
	{
		return _grid[r][c] == 1;
	}

	private void DfsCircle(int r, int c)
	{
		MarkCellAsVisited(r, c);
		int area = 1;

		if (r - 1 >= 0 && IsCircleFound(r - 1, c))
			DfsCircle(r - 1, c);

		if (r + 1 < _height && IsCircleFound(r + 1, c))
			DfsCircle(r + 1, c);

		if (c - 1 >= 0 && IsCircleFound(r, c - 1))
			DfsCircle(r, c - 1);

		if (c + 1 < _width && IsCircleFound(r, c + 1))
			DfsCircle(r, c + 1);
	}

	private void MarkCellAsVisited(int r, int c)
	{
		_grid[r][c] = -1;
	}
}