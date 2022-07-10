var s = new Solution();
var r = s.SubsetsWithDup(new int[] { 4,4,4,1,4 });

foreach (var i in r)
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine(string.Join(" ", i));
}