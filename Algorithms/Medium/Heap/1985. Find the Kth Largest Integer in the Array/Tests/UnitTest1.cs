using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData(new string[] { "3", "6", "7", "10" }, 4, "3")]
    [InlineData(new string[] { "2", "21", "12", "1" }, 3, "2")]
    public void Test1(string[] input, int k, string expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.KthLargestNumber(input, k);

        // assert
        Assert.Equal(expected, actual);
    }
}