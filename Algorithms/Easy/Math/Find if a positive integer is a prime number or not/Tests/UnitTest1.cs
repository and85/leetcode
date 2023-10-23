namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData(17, true)]
    [InlineData(20, false)]
    [InlineData(13, true)]
    [InlineData(14, false)]
    public void Test1(int input, bool expected)
    {
        // arrange and act
        var actual = Solution.FindPrime(input);       

        // assert
        Assert.Equal(expected, actual);
    }
}