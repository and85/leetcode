using System;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]    
    public void Test1()
    {
        // arrange
        var input = new int[][]
        {
            new int[] { 0, 1 },
            new int[] { 0, 2 },
            new int[] { 1,2 }
        };
        var s = new Solution();

        // act
        long actual = s.CountPairs(3, input);

        // assert
        Assert.Equal(0, actual);
    }

    [Fact]    
    public void Test2()
    {
        // arrange
        var input = new int[][]
        {
            new int[] { 0,2 },
            new int[] { 0,5 },
            new int[] { 2,4 },
            new int[] { 1,6 },
            new int[] { 5,4 },
        };
        var s = new Solution();

        // act
        long actual = s.CountPairs(7, input);

        // assert
        Assert.Equal(14, actual);
    }    
}