using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // arrange
        var solution = new Solution();
        int[][] input = new int[][] 
        {
            new int[] {0,1,0,0},
            new int[] {1,1,1,0},
            new int[] {0,1,0,0},
            new int[] {1,1,0,0}
        };

        // act
        var actual = solution.IslandPerimeter(input);

        // assert
        Assert.Equal(16, actual);
    }

    [Fact]
    public void Test2()
    {
        // arrange
        var solution = new Solution();
        int[][] input = new int[][] 
        {
            new int[] {1}
        };

        // act
        var actual = solution.IslandPerimeter(input);

        // assert
        Assert.Equal(4, actual);
    }

    [Fact]
    public void Test3()
    {
        // arrange
        var solution = new Solution();
        int[][] input = new int[][] 
        {
            new int[] {1, 0}
        };

        // act
        var actual = solution.IslandPerimeter(input);

        // assert
        Assert.Equal(4, actual);
    }

    [Fact]
    public void Test4()
    {
        // arrange
        var solution = new Solution();
        int[][] input = new int[][] 
        {
            new int[] {1, 1},
            new int[] {1, 1},
        };

        // act
        var actual = solution.IslandPerimeter(input);

        // assert
        Assert.Equal(8, actual);
    }
}