using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]

    public void Test1()
    {
        // arrange
        var solution = new Solution();
        int[][] statements = new int[][]
        {
            new int[] {2,1,2},
            new int[] {1,2,2},
            new int[] {2,0,2}
        };

        // act
        var actual = solution.MaximumGood(statements);

        // assert
        Assert.Equal(2, actual);
    }

    [Fact]
    public void Test2()
    {
        // arrange
        var solution = new Solution();
        int[][] statements = new int[][]
        {
            new int[] {2, 0},
            new int[] {0, 2},
        };

        // act
        var actual = solution.MaximumGood(statements);

        // assert
        Assert.Equal(1, actual);
    }
}