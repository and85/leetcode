using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 0)]
    public void Test1(int input, int expected)
    {
        // arrange
        var s = new Solution();

        // act
        int actual = s.Method(input);

        // assert
        Assert.Equal(expected, actual);
    }
}