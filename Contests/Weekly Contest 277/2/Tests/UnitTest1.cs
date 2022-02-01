using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] { 3, 1, -2, -5, 2, -4 }, new int[] { 3, -2, 1, -5, 2, -4 })]
    [InlineData(new int[] { -1, 1 }, new int[] { 1, -1 })]
    public void Test1(int[] input, int[] expected)
    {
        // arrange
        var solution = new Solution();

        // act
        int[] actual = solution.RearrangeArray(input);

        // assert
        Assert.Equal(expected, actual);
    }
}