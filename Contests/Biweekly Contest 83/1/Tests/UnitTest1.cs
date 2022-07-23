using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {13, 2, 3, 1, 9}, new char[] { 'a', 'a', 'a', 'a', 'a'}, "Flush")]
    [InlineData(new int[] {4,4,2,4,4}, new char[] { 'd', 'a','a', 'b', 'c'}, "Three of a Kind")]
    [InlineData(new int[] {10,10,2,12,9}, new char[] { 'a', 'b', 'c', 'a', 'd'}, "Pair")]
    [InlineData(new int[] {1, 2, 3, 4, 5}, new char[] { 'a', 'b', 'c', 'd', 'd'}, "High Card")]
    public void Test1(int[] ranks, char[] suits, string expected)
    {
        // arrange
        var solution = new Solution();

        // act
        string actual = solution.BestHand(ranks, suits);

        // assert
        Assert.Equal(expected, actual);
    }
}