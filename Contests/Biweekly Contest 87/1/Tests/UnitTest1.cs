using Xunit;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("08-15", "08-18", "08-16", "08-19", 3)]
    [InlineData("10-01", "10-31", "11-01", "12-31", 0)]   
    [InlineData("02-28", "02-28", "02-28", "03-28", 1)]    
    public void Test1(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob, 
        int expected)
    {
        // arrange
        var solution = new Solution();

        // act
        int actual = solution.CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob);

        // assert
        Assert.Equal(expected, actual);
    }
}