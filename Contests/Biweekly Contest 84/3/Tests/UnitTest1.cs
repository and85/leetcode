using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {1,2,1,2,3,1}, 3, 9)]    
    [InlineData(new int[] {5,8,8,5}, 2, 6)]    
    public void Test1(int[] tasks, int space, long expected)
    {
        // arrange
        var solution = new Solution();

        // act
        long actual = solution.TaskSchedulerII(tasks, space);

        // assert
        Assert.Equal(expected, actual);
    }
}