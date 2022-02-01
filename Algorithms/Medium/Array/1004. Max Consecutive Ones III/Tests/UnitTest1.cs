using Xunit;

namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] { 1,1,1,0,0,0,1,1,1,1,0 }, 2, 6)]
    [InlineData(new int[] { 0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1 }, 3, 10)]
    public void Test1(int[] input, int target, int expected)
    {
        // arrange
        var s = new Solution();

        // act
        int actual = s.MaxNonOverlapping(input, target);

        // assert
        Assert.Equal(expected, actual);
    }
}