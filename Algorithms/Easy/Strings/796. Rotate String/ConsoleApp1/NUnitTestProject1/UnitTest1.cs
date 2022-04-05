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

        [TestCase("abcde", "cdeab", true)]        
        [TestCase("abcde", "abced", false)]
        [TestCase("abcde", "bcdea", true)]
        [TestCase("abcde", "bcdea", true)]
        [TestCase("abcde", "cdeab", true)]
        [TestCase("abcde", "deabc", true)]
        [TestCase("abcde", "eabcd", true)]
        [TestCase("abcde", "abcde", true)]
        [TestCase("bqqutquvbtgouklsayfvzewpnrbwfcdmwctusunasdbpbmhnvy", "wpnrbwfcdmwctusunasdbpbmhnvybqqutquvbtgouklsayfvze", true)]        
        public void Test1(string a, string b, bool expected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.RotateString(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}