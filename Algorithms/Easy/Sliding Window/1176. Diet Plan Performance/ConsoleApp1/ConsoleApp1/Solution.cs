using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            int points = 0;
            int caloriesSum = GetInitialCalories(calories, k, lower, upper);
            points = CalculatePoints(lower, upper, points, caloriesSum);

            for (int i = k; i < calories.Length; i++)
            {
                // caclulate change in calories sum while moving sliding window
                caloriesSum += calories[i];
                caloriesSum -= calories[i - k];
                points = CalculatePoints(lower, upper, points, caloriesSum);
            }

            return points;
        }

        private int CalculatePoints(int lower, int upper, int curPoints, int caloriesSum)
        {
            if (caloriesSum < lower)
                curPoints--;
            if (caloriesSum > upper)
                curPoints++;

            return curPoints;
        }

        private int GetInitialCalories(int[] calories, int k, int lower, int upper)
        {
            int res = 0;
            for (int i = 0; i < k; i++)
            {
                res += calories[i];
            }

            return res;
        }
    }
}
