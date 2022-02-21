using Xunit;

namespace Tests;

public class UnitTest1
{    
    [Theory]
    [InlineData(new[] {3,1,2,2,2,1,3}, 2, 4)]
    [InlineData(new[] {1,2,3,4}, 1, 0)]
    public void Test1(int[] input, int k, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.CountPairs(input, k);

        // assert
        Assert.Equal(expected, actual);
    }
}