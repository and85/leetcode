using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int oldColor = image[sr][sc];
            Dfs(image, sr, sc, oldColor, newColor);
            
            return image;
        }

        private void Dfs(int[][] image, int sr, int sc, int oldColor, int newColor)
        {
            if (image[sr][sc] != oldColor || image[sr][sc] == newColor)
                return;

            image[sr][sc] = newColor;

            if (sr + 1 < image.Length)
                Dfs(image, sr + 1, sc, oldColor, newColor);
            if (sr - 1 >= 0)
                Dfs(image, sr - 1, sc, oldColor, newColor);
            if (sc + 1 < image[sr].Length)
                Dfs(image, sr, sc + 1, oldColor, newColor);
            if (sc - 1 >= 0)
                Dfs(image, sr, sc - 1, oldColor, newColor);
        }
    }
}
