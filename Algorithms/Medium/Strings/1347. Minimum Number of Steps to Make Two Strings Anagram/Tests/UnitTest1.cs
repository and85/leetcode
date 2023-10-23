namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("bab", "aba", 1)]
    [InlineData("leetcode", "practice", 5)]
    // l 1, e 3, t 1, c 1, o 1, d 1 

    [InlineData("anagram", "mangaar", 0)]
    public void Test1(string s, string t, int expected)
    {
        // arrange
        var sol = new Solution();       

        // act
        int actual = sol.MinSteps(s, t);

        // assert
        Assert.Equal(expected, actual);
    }
}