using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(1, 2, 1, 600, 6)]
    [InlineData(0, 1, 2, 76, 6)]
    [InlineData(9, 100000, 1, 6039, 4)]
    [InlineData(5, 15, 20, 365, 90)]
    [InlineData(0, 9, 18, 460, 81)]
    public void Test1(int startAt, int moveCost, int pushCost, int targetSeconds, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.MinCostSetTime(startAt, moveCost, pushCost, targetSeconds);

        // assert
        Assert.Equal(expected, actual);
    }
}