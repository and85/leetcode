using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    /*
    [InlineData("123", '3', "12")]
    [InlineData("1231", '1', "231")]
    [InlineData("551", '5', "51")]
    */
    [InlineData("2998589353917872714814599237991174513476623756395992135212546127959342974628712329595771672911914471", '3', "299858953917872714814599237991174513476623756395992135212546127959342974628712329595771672911914471")]
    public void Test1(string number, char digit, string expected)
    {
        // arrange
        var solution = new Solution();

        // act
        string actual = solution.RemoveDigit(number, digit);

        // assert
        Assert.Equal(expected, actual);
    }
}