using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[3][];
            intervals[0] = new int[2] { 0, 30 };
            intervals[1] = new int[2] { 5, 10 };
            intervals[2] = new int[2] { 15, 20 };

            var solution = new Solution();
            solution.CanAttendMeetings(intervals);

        }
    }
}
