var s = new Solution();

int[][] first = new int[][]
{
    /*
    new int[] {0, 2},
    new int[] {5, 10},
    new int[] {13, 23},
    new int[] {24, 25}
    */
    new int[] {1, 3}, 
    new int[] {5, 9}
};

int[][] second = new int[][]
{
    /*
    new int[] {1, 5},
    new int[] {8, 12},
    new int[] {15, 24},
    new int[] {25, 26}
    */    
};

foreach(var interval in s.IntervalIntersection(first, second))
{
    Console.WriteLine(interval[0] + " " + interval[1]);
}

