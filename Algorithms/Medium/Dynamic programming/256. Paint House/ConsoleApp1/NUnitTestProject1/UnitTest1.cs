using ConsoleApp1;
using NUnit.Framework;

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
            var solution = new Solution();

            // act
            int actual = solution.MinCost(new int[3][] {
                new int[] { 17,2,17 },
                new int[] { 16,16,5 },
                new int[] { 14,3,19 }
            });

            // assert
            Assert.AreEqual(10, actual);
        }
    }
}