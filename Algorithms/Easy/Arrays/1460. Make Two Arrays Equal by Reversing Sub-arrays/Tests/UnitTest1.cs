using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new[] {1,2,3,4}, new[] {2,4,1,3}, true)]
    [InlineData(new[] {7}, new[] {7}, true)]
    [InlineData(new[] {3,7,9}, new[] {3,7,9}, true)]
    public void Test1(int[] target, int[] arr, bool expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.CanBeEqual(target, arr);

        // assert
        Assert.Equal(expected, actual);
    }
}