var solution = new Solution();

var actual1 = solution.TwoSum(new int[] {2,7,11,15}, 9);
Console.WriteLine($"{actual1[0]}, {actual1[1]}");

var actual2 = solution.TwoSum(new int[] {3, 3}, 6);
Console.WriteLine($"{actual2[0]}, {actual2[1]}");

var actual3 = solution.TwoSum(new int[] {3, 2, 4}, 6);
Console.WriteLine($"{actual3[0]}, {actual3[1]}");