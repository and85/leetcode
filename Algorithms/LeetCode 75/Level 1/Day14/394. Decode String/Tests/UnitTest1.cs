using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("3[a]2[bc]", "aaabcbc")]    
    [InlineData("3[a2[c]]", "accaccacc")]
    [InlineData("2[abc]3[cd]ef", "abcabccdcdcdef")]
    public void Test1(string input, string expected)
    {
        // arrange
        var solution = new Solution();

        // act
        string actual = solution.DecodeString(input);

        // assert
        Assert.Equal(expected, actual);
    }
}