var s = new Solution();
foreach (int el in s.SortArray(new int[] { 5, 2, 3, 1 }))
{
    Console.Write(el + " ");
}

Console.WriteLine();

foreach (int el in s.SortArray(new int[] { 5, 1, 1, 2, 0, 0 }))
{
    Console.Write(el + " ");
}

foreach (int el in s.SortArray(new int[] { 1, 2, 3 }))
{
    Console.Write(el + " ");
}
