using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public double AngleClock(int hour, int minutes)
        {
            if (hour == 12)
                hour = 0;

            double hourAngle = hour * 30 + minutes / 60.0 * 30;
            double minutesAngle = minutes * 6;
            double angle = Math.Abs(minutesAngle - hourAngle);
            if (angle >= 180)
                angle = 360 - angle;

            return angle;
        }
    }
}
