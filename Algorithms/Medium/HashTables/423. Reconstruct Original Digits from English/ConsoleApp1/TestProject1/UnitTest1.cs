using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("owoztneoer", "012")]
        [InlineData("fviefuro", "45")]
        [InlineData("zeroonetwothreefourfivesixseveneightnine", "0123456789")]
        public void Test1(string input, string expected)
        {
            // arrange
            var solution = new Solution();

            // act
            string actual = solution.OriginalDigits(input);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
