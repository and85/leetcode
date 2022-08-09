namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("foo", "bar", false)]
    [InlineData("paper", "title", true)]
    [InlineData("paper", "tiple", false)]
    [InlineData("daper", "title", false)]    
    public void Test1(string s, string t, bool expected)
    {
        // arrange
        var solution = new Solution();

        // act
        bool actual = solution.IsIsomorphic(s, t);

        // assert
        Assert.Equal(expected, actual);
    }
}