using ConsoleApp1;

var solution = new Solution();
solution.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
solution.Merge(new int[] { 1 }, 1, new int[] { }, 0 );
solution.Merge(new int[] { 2, 0 }, 1, new int[] { 1 }, 1);