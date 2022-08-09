namespace tests;

public class UnitTest1
{
    [Theory]    
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("abc", "abd", false)]
    [InlineData("axc", "ahbgdc", false)]
    [InlineData("b", "c", false)]
    [InlineData("b", "b", true)]
    [InlineData("b", "bb", true)]
    [InlineData("b", "bc", true)]
    [InlineData("ab", "bac", false)]
    [InlineData("", "bac", true)]
    [InlineData("abc", "", false)]
    [InlineData("aaaaaa", "bbaaaa", false)]    
    [InlineData("bb", "ahbgdc", false)]
    [InlineData("ab", "baab", true)]
    public void Test1(string s, string t, bool expected)
    {
        // arrange
        var solution = new Solution();

        // act
        bool actual = solution.IsSubsequence(s, t);

        // assert
        Assert.Equal(expected, actual);
    }
}