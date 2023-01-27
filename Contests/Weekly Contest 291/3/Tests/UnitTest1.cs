using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {11,7,2,15}, 2)]
    [InlineData(new int[] {-3,3,3,90}, 2)]
    [InlineData(new int[] {1}, 0)]
    [InlineData(new int[] {1, 10000}, 0)]
    public void Test1(int[] input, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        int actual = solution.CountElements(input);

        // assert
        Assert.Equal(expected, actual);
    }
}