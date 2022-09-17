using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {1,0,2,1,3}, new int[] {3,3,2,2,1})]
    [InlineData(new int[] {1, 2}, new int[] {2, 1})]    
    [InlineData(new int[] {4,0,5,6,3,2}, new int[] {4,3,2,2,1,1})] 
    public void Test1(int[] a, int[] expected)
    {
        // arrange
        var solution = new Solution();

        // act
        int[] actual = solution.SmallestSubarrays(a);

        // assert
        Assert.Equal(expected, actual);
    }
}