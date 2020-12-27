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
            int expected = 6;
            var input = new char[][]
            {
                new[] { '1', '0', '1', '0', '0' },
                new[] {'1', '0', '1', '1', '1' },
                new[] {'1', '1', '1', '1', '1'},
                new[] {'1', '0', '0', '1', '0'}
            };

            // act
            int actual = solution.MaximalRectangle(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var solution = new Solution();
            int expected = 0;
            var input = new char[][]
            {
            };

            // act
            int actual = solution.MaximalRectangle(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            // arrange
            var solution = new Solution();
            int expected = 0;
            var input = new char[][]
            {
                new[] { '0'}
            };

            // act
            int actual = solution.MaximalRectangle(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            // arrange
            var solution = new Solution();
            int expected = 0;
            var input = new char[][]
            {
                new[] { '1'}
            };

            // act
            int actual = solution.MaximalRectangle(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            // arrange
            var solution = new Solution();
            int expected = 0;
            var input = new char[][]
            {
                new[] { '0', '0'}
            };

            // act
            int actual = solution.MaximalRectangle(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}