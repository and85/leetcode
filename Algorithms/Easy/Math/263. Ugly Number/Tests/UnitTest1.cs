using Xunit;

namespace Tests;

public class UnitTest1
{    
    [Theory]
    [InlineData(6, true)]
    [InlineData(1, true)]
    [InlineData(14, false)]
    public void Test1(int input, bool expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.IsUgly(input);

        // assert
        Assert.Equal(expected, actual);
    }
}