namespace tests;

public class UnitTest1
{
    [Theory]
    [InlineData("Welcome to Csharp corner", "emocleW ot prahsC renroc")]
    public void Test1(string input, string expected)
    {
        // arrange and act
        var actual = Solution.ReverseWords(input);       

        // assert
        Assert.Equal(expected, actual);
    }
}