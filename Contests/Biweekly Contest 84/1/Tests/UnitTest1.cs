using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {13, 2, 3, 1, 9}, "Flush")]    
    public void Test1(int[] a, string expected)
    {
        // arrange
        var solution = new Solution();

        // act
        string actual = solution.Method(a);

        // assert
        Assert.Equal(expected, actual);
    }
}