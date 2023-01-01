namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("aaasadbutsad", "sad", 3)]
    [InlineData("", "", -1)]
    [InlineData("", "sad", -1)]
    [InlineData(null, null, -1)]
    [InlineData("abc", "c", 2)]
    public void Test1(string haystack, string needle, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        int actual = solution.StrStr(haystack, needle);

        // assert
        Assert.Equal(expected, actual);
    }
}