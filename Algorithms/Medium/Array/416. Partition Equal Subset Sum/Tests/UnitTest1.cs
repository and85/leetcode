using Xunit;

namespace Tests;

public class UnitTest1
{
    //[Fact]
    [Theory]
    
    [InlineData(new[] { 1, 5, 11, 5 }, true)]
    [InlineData(new[] { 1, 2, 3, 5 }, false)]
    [InlineData(new[] { 1, 1, 1, 1, 1, 3, 4, 4, 8  }, true)]
    [InlineData(new[] { 1, 1, 1, 1, 3, 4, 4, 8  }, false)]
    [InlineData(new[] { 0, 1  }, false)]
    [InlineData(new[] { 1, 1  }, true)]
    [InlineData(new[] { 0, 0  }, true)]
    [InlineData(new[] { 0, 0, 1, 1 }, true)]
    [InlineData(new[] { 0, 0, 1 }, false)]
    [InlineData(new[] { 2, 2, 1, 1 }, true)]
    [InlineData(new[] { 1, 2, 5 }, false)]
    
    [InlineData(new[] { 100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,99,97 }, false)]
    public void Test1(int[] input, bool expected)
    {
        // arrange
        var solution = new Solution();

        // act
        var actual = solution.CanPartition(input);
        //var actual = solution.CanPartition(new[] {1, 2, 5});
        //var actual = solution.CanPartition(new[] {1, 1});

        // assert
        Assert.Equal(expected, actual);
    }
}