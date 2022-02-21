using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]                            
    [InlineData(0, new long[] {})]
    [InlineData(1, new long[] {})]
    [InlineData(2, new long[] {})]        
    [InlineData(3, new long[] {0, 1, 2})]
    [InlineData(4, new long[] {})]
    [InlineData(5, new long[] {})]
    [InlineData(6, new long[] {1, 2, 3})]    
    
    [InlineData(33, new long[] {10,11,12})]
    [InlineData(39, new long[] {12,13,14})]

    [InlineData(433223717, new long[] {})]
    [InlineData(562789250, new long[] {})]    
    [InlineData(999_999_999_999_999, new long[] {333333333333332, 333333333333333, 333333333333334})]            
    [InlineData(1_000_000_000_000_000, new long[] {})]    
    public void Test1(long input, long[] expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.SumOfThree(input);

        // assert
        Assert.Equal(expected, actual);
    }
}