using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 8, 1, 2, 2, 3 }, new int[] {4,0,1,1,3})]
        [TestCase(new int[] { 6, 5, 4, 8 }, new int[] { 2, 1, 0, 3 })]
        [TestCase(new int[] { 7, 7, 7, 7 }, new int[] { 0, 0, 0, 0 })]
        public void Test1(int[] input, int[] expected)
        {
            // arrange
            var solution = new ConsoleApp1.Solution();

            // act
            var actual = solution.SmallerNumbersThanCurrent(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}