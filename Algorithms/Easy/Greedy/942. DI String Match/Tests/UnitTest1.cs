namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("IDID", new int[] { 0, 4, 1, 3, 2 })]
    [InlineData("III", new int[] { 0, 1, 2, 3 })]
    [InlineData("DDI", new int[] { 3, 2, 0, 1 })]
    public void Test1(string input, int[] expected)
    {
        // arrange
        var s = new Solution();

        // act
        int[] actual = s.DiStringMatch(input);

        // assert
        Assert.Equal(expected, actual);
    }
}