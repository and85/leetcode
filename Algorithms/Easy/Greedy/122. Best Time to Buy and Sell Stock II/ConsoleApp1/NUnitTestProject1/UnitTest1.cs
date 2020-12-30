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
            // arange
            var solution = new Solution();
            int expected = 7;

            // act
            int actual = solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            // arange
            var solution = new Solution();
            int expected = 4;

            // act
            int actual = solution.MaxProfit(new int[] { 1, 2, 3, 4, 5 });

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            // arange
            var solution = new Solution();
            int expected = 0;

            // act
            int actual = solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 });

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}