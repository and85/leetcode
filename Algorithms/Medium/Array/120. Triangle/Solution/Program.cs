// See https://aka.ms/new-console-template for more information
var s = new Solution();

IList<IList<int>> triangle = new List<IList<int>>()
{
    new List<int>() {2},
    new List<int>() {3, 4},
    new List<int>() {6, 5, 7},
    new List<int>() {4, 1, 8, 3},
};

IList<IList<int>> triangle2 = new List<IList<int>>()
{
    new List<int>() {-10}
};

s.MinimumTotal(triangle);
s.MinimumTotal(triangle2);
