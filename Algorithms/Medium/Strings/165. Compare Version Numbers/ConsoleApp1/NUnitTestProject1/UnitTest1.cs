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

        [TestCase("1.01", "1.001", 0)]
        [TestCase("1.0", "1.0.0", 0)]
        [TestCase("0.1", "1.1", -1)]
        [TestCase("1.0.1", "1", 1)]
        [TestCase("7.5.2.4", "7.5.3", -1)]
        public void Test1(string v1, string v2, int excepcted)
        {
            // arrange
            var solution = new Solution();

            // act
            int actual = solution.CompareVersion(v1, v2);

            // assert
            Assert.AreEqual(excepcted, actual);
        }
    }
}