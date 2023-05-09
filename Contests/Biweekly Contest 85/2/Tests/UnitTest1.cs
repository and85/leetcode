namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("0110101", 4)]
    [InlineData("11100", 0)]
    public void Test1(string s, int expected)
    {
        // arrange
        var solution = new Solution();
        
        // act
        int actual = solution.SecondsToRemoveOccurrences(s);

        // assert
        Assert.Equal(expected, actual);
        
    }
}