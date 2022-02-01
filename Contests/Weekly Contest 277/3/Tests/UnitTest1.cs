using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] { 10,6,5,8 }, new int[] { 10,8 })]
    [InlineData(new int[] { 10,6,5,8, 10 }, new int[] { 8 })]
    [InlineData(new int[] { 1,3,5,3 }, new int[] { 1,5 })]
    public void Test1(int[] input, int[] expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.FindLonely(input).ToArray();        

        // assert
        Assert.Equal(expected, actual);
    }
}