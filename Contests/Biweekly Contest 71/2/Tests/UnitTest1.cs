using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new int[] { 9,12,5,10,14,3,10 }, 10, new int[] { 9,5,3,10,10,12,14 })]
    [InlineData(new int[] { -3,4,3,2 }, 2, new int[] { -3,2,4,3 })]
    public void Test1(int[] input, int pivot, int[] expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.PivotArray(input, pivot);

        // assert
        Assert.Equal(expected, actual);
    }
}