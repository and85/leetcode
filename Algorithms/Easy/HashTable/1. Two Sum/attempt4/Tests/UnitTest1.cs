using System;
using Xunit;

namespace Tests;

public class UnitTest1
{ 
    //[Fact]
    [Theory]
    [InlineData(int[] {2,7,11,15}, 9, int[] {0, 1})]        
    public void Test1(int[] input, int target, int[] expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.TwoSum(input, target);

        // assert
        Assert.Equal(expected, actual);        
    }
}