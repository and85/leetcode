using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            int maxDuration = 0, duration;
            char maxKey = 'a';
            int prevRelease = 0;

            for (int i = 0; i < releaseTimes.Length; i++)
            {
                duration = releaseTimes[i] - prevRelease;
                
                if (duration == maxDuration)
                {
                    maxKey = keysPressed[i] > maxKey ? keysPressed[i] : maxKey;
                }
                else if (duration > maxDuration)
                {
                    maxDuration = duration;
                    maxKey = keysPressed[i];
                }
                

                prevRelease = releaseTimes[i];
            }

            return maxKey;
        }
    }
}
