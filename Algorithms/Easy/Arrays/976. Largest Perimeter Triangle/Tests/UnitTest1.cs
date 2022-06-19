using Xunit;

namespace Tests;

public class UnitTest1
{
     [Theory]
    [InlineData(new int[] {2, 1, 2}, 5)]
    [InlineData(new int[] {1, 2, 1}, 0)]
    public void Test1(int[] nums, int expected)
    {
        // arrange
        var s = new Solution();

        // act
        int actual = s.LargestPerimeter(nums);

        // assert 
        Assert.Equal(expected, actual);
    }
}