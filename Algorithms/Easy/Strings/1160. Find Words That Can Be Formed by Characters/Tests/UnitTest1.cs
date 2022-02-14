using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(1, 0)]
    public void Test1(int input, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.Method1(input);

        // assert
        Assert.Equal(expected, actual);
    }
}