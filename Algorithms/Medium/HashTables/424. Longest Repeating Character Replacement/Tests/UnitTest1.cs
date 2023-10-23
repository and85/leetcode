namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("ABAB", 2, 4)]
    [InlineData("AABABBA", 1, 4)]
    public void Test1(string s, int k, int expected)
    {
        // arrange
        var sol = new Solution();       

        // act
        int actual = sol.CharacterReplacement(s, k);

        // assert
        Assert.Equal(expected, actual);
    }
}