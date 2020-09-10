using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public double Average(int[] salary)
        {
            int minSalary = int.MaxValue;
            int maxSalary = int.MinValue;
            double totalSalary = 0;

            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] < minSalary)
                    minSalary = salary[i];
                if (salary[i] > maxSalary)
                    maxSalary = salary[i];

                totalSalary += salary[i];
            }

            return (totalSalary - minSalary - maxSalary) / (salary.Length - 2);
        }
    }
}
