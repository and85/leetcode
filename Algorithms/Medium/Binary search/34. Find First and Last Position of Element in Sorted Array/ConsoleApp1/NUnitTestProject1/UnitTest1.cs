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

        [TestCase(new int[] { 3, 3, 3 }, 3, new int[] { 0, 2 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 0, 0 })]
        [TestCase(new int[] { 3, 1 }, 1, new int[] { 1, 1 })]
        [TestCase(new int[] { 1, 3 }, 1, new int[] { 0, 0 })]
        [TestCase(new int[] { 3, 2, 1 }, 3, new int[] { 0, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, new int[] { 2, 2 })]
        [TestCase(new int[] { 2, 2 }, 3, new int[] { -1, -1 })]
        [TestCase(new int[] { 2 }, 3, new int[] { -1, -1 })]
        [TestCase(new int[] { 3, 3 }, 3, new int[] { 0, 1 })]
        [TestCase(new int[] { 1, 3, 3 }, 3, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 3, 3, 2, 4, 5 }, 3, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 3, 4, 5 }, 3, new int[] { 2, 3 })]
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4})]
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1})]
        [TestCase(new int[] { }, 0, new int[] { -1, -1 })]
        public void Test1(int[] nums, int target, int[] expected)
        {
            // arrange
            var solution = new Solution();

            // act
            int[] actual = solution.SearchRange(nums, target);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}