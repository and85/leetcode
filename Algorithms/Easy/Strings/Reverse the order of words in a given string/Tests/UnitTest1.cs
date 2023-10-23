namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("Welcome to Csharp corner", "corner Csharp to Welcome")]
    public void Test1(string input, string expected)
    {
        // arrange and act
        var actual = Solution.ReverseWordOrder(input);       

        // assert
        Assert.Equal(expected, actual);
    }
}