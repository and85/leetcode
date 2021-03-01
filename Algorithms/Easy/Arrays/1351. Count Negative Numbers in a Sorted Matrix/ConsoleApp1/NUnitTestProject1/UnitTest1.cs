using NUnit.Framework;
using ConsoleApp1;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // arrange
            var grid = new int[][]
            {
                new int[] {  4,  3,   2,  -1 },
                new int[] {  3,  2,   1,  -1 },
                new int[] {  1,  1,  -1,  -2 },
                new int[] { -1,- 1,  -2,  -3 } 
            };
            var solution = new Solution();

            // act
            int actual = solution.CountNegatives(grid);

            // assert
            Assert.AreEqual(8, actual);
        }
    }
}