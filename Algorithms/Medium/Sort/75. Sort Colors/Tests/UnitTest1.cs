using Xunit;

namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
    [InlineData(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2 })]
    [InlineData(new int[] { 1, 2, 0 }, new int[] { 0, 1, 2 })]
    public void Test1(int[] input, int[] expected)
    {
        // arrange
        var solution = new Solution();

        // act
        solution.SortColors(input);

        // assert
        Assert.Equal(expected, input);
    }
}