﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int l = 0, r = height.Length - 1, max = 0, area;

            while (l < r)
            {
                area = Math.Min(height[l], height[r]) * (r - l);
                max = Math.Max(area, max);                
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
                
            }

            return max;
        }
    }
}
