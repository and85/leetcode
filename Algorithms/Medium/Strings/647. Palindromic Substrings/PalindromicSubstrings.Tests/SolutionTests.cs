using Xunit;

namespace PalindromicSubstrings.Tests;

public class SolutionTests
{
    [Theory]
    [InlineData("abc", 3)]
    [InlineData("aaa", 6)]    
    public void CountSubstrings(string input, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        int actual = solution.CountSubstrings(input);

        // assert
        Assert.Equal(expected, actual);
    }
}