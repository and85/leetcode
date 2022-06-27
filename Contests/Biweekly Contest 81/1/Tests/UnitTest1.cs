using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("l|*e*et|c**o|*de|", 2)]
    [InlineData("iamprogrammer", 0)]
    [InlineData("yo|uar|e**|b|e***au|tifu|l", 5)]
    [InlineData("l|*e*et|", 0)]
    [InlineData("l|*e*et|*|", 1)]
    [InlineData("l*", 1)]
    [InlineData("A", 0)]
    [InlineData("*", 1)]
    public void Test1(string input, int expected)
    {
        // arrange
        var s = new Solution();

        // act
        int actual = s.CountAsterisks(input);

        // assert
        Assert.Equal(expected, actual);
    }
}