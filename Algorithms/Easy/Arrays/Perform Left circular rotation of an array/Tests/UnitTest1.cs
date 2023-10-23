namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[] {1, 2, 3, 4, 5}, new int[] {2, 3, 4, 5, 1 })]
    public void Test1(int[] array, int[] expected)
    {
        // arrange and act
        Solution.RotateLeft(array);       

        // assert
        Assert.Equal(expected, array);
    }
}