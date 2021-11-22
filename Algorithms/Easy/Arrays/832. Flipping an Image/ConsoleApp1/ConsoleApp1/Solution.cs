using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            for (int r = 0; r < image.Length; r++)
            {
                int cl = 0, cr = image[r].Length - 1;

                while (cr >= cl)
                {
                    if (image[r][cl] == image[r][cr])
                    {
                        image[r][cl] = Convert.ToInt32(!Convert.ToBoolean(image[r][cl]));
                        image[r][cr] = image[r][cl];
                    }

                    cl++;
                    cr--;
                }

            }

            return image;
        }
    }
}
