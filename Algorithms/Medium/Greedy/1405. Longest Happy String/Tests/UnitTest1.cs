using Xunit;

namespace Tests;

public class UnitTest1
{    
    [Theory]
    [InlineData(1, 1, 7, "ccaccbcc")]
    [InlineData(7, 1, 0, "aabaa")]
    public void Test1(int a, int b, int c, string expected )
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.LongestDiverseString(a, b, c);

        // assert
        Assert.Equal(expected, actual);
    }
}