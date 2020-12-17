public class Solution
{
	private int _height;
	private int _width;
	private int[][] _grid;


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