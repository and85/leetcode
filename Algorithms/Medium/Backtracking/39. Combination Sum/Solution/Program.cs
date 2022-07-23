var s = new Solution();
var r1 = s.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);

foreach (var r in r1)
{
    Console.WriteLine(string.Join(",", r));
}

Console.WriteLine("--------------------------------------------------------");
var r2 = s.CombinationSum(new int[] { 2, 3, 5 }, 8);

foreach (var r in r1)
{
    Console.WriteLine(string.Join(",", r));
}

Console.WriteLine("--------------------------------------------------------");