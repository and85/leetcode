using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {4,1,3,3}, 5)]    
    [InlineData(new int[] {1,2,3,4,5}, 0)]  
    [InlineData(new int[] {43,69,66,40,33}, 10)]  
    public void Test1(int[] a, long expected)
    {
        // arrange
        var solution = new Solution();

        // act
        long actual = solution.CountBadPairs(a);

        // assert
        Assert.Equal(expected, actual);
    }
}