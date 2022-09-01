var s = new Solution();
var grid = new int[][]
{
    new int[] {0,0,1,1,0,1,0,0,1,0},
    new int[] {1,1,0,1,1,0,1,1,1,0},
    new int[] {1,0,1,1,1,0,0,1,1,0},
    new int[] {0,1,1,0,0,0,0,1,0,1},
    new int[] {0,0,0,0,0,0,1,1,1,0},
    new int[] {0,1,0,1,0,1,0,1,1,1},
    new int[] {1,0,1,0,1,1,0,0,0,1},
    new int[] {1,0,1,0,1,1,0,0,0,1},
    new int[] {1,1,1,1,1,1,0,0,0,0},
    new int[] {1,1,1,0,0,1,0,1,0,1},
    new int[] {1,1,1,0,1,1,0,1,1,0}    
};

Console.WriteLine(s.ClosedIsland(grid));