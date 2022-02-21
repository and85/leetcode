using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    [InlineData("leetcode", new[] { "leet", "code" }, true)]
    [InlineData("applepenapple", new[] { "apple","pen" }, true)]
    [InlineData("catsandog", new[] { "cats","dog","sand","and","cat" }, false)]
    [InlineData("bb", new[] { "a","b","bbb","bbbb" }, true)]
    [InlineData("aaaaaaa", new[] { "aaaa","aaa" }, true)]            
    public void Test1(string input, string[] wordDict, bool expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.WordBreak(input, wordDict);

        // assert
        Assert.Equal(expected, actual);
    }
}