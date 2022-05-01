using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            /*
            int[][] slots1 = new int[][]
            {
                new int[] { 10, 50 },
                new int[] { 60,120 },
                new int[] { 140,210 }
            };
            int[][] slots2 = new int[][]
            {
                new int[] { 0,15 },
                new int[] { 60,70 }
            };

            solution.MinAvailableDuration(slots1, slots2, 8);
            */
            int[][] slots1 = new int[][]
            {
                new int[] { 216397070, 363167701 },
                new int[] { 98730764,  158208909 },
                new int[] { 441003187, 466254040 },
                new int[] { 558239978, 678368334 },                
                new int[] { 683942980, 717766451 }

            };
            int[][] slots2 = new int[][]
            {
                new int[] { 50490609,  222653186 },
                new int[] { 512711631, 670791418 },
                new int[] { 730229023, 802410205 },
                new int[] { 812553104, 891266775 },
                new int[] { 230032010, 399152578 }
            };

            solution.MinAvailableDuration(slots1, slots2, 8);



            Console.WriteLine();
        }
    }
}
