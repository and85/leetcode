using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] DailyTemperatures(int[] T)
        {
            int[] result = new int[T.Length];
            int lastTemperature = T[T.Length - 1];
            int countDays = 0, next, prev, maxTemperature = lastTemperature; 
            var futureTemperatures = new Stack<int>();
            futureTemperatures.Push(lastTemperature);

            for (int i = T.Length - 1; i > 0; i--)
            {
                next = T[i - 1];
                prev = T[i];

                if (next < prev)
                {
                    futureTemperatures.Push(next);
                    result[i - 1] = 1;
                }

                if (next >= prev)
                {
                    if (next >= maxTemperature)
                    {
                        maxTemperature = next;
                        futureTemperatures.Clear();
                        futureTemperatures.Push(maxTemperature);
                        result[i - 1] = 0;
                    }
                    else
                    {
                        countDays = 1;
                        foreach (int day in futureTemperatures)
                        {
                            if (day <= next)
                                countDays++;
                            else
                                break;
                        }
                        futureTemperatures.Push(next);
                        result[i - 1] = countDays;
                    }
                }
            }

            return result;
        }
    }
}
