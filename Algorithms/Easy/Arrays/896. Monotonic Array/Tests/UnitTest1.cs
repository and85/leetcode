using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tests;

public class UnitTest1
{

    [Theory]
    [InlineData(new[] { 1, 2, 2, 3 }, true)]
    [InlineData(new[] { 6, 5, 4, 4 }, true)]
    [InlineData(new[] { 6, 5, 4, 4, 5 }, false)]
    [InlineData(new[] { 1, 3, 2 }, false)]
    public void Test(int[] input, bool expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.IsMonotonic(input);

        // assert
        Assert.Equal(expected, actual);
    }


}