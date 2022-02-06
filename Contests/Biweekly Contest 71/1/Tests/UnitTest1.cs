using System;
using Xunit;

namespace Tests;

public class UnitTest1
{ 
    //[Fact]
    [Theory]
    [InlineData(2932, 52)]    
    [InlineData(4009, 13)]
    public void Test1(int input, int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.MinimumSum(input);

        // assert
        Assert.Equal(expected, actual);        
    }
}