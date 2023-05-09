namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("WBBWWBBWBW", 7, 3)]
    [InlineData("WBWBBBW", 2, 0)]
    public void Test1(string blocks, int k, int expected)
    {
        // arrange
        var solution = new Solution();
        
        // act
        int actual = solution.MinimumRecolors(blocks, k);

        // assert
        Assert.Equal(expected, actual);
        
    }
}