using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {1,3,0,0,2,0,0,4}, 6)]
    [InlineData(new int[] {0,0,0,2,0,0}, 9)]
    [InlineData(new int[] {2,10,2019}, 0)]
    
    public void Test1(int[] nums, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        long actual = solution.ZeroFilledSubarray(nums);

        // assert
        Assert.Equal(expected, actual);
    }
}