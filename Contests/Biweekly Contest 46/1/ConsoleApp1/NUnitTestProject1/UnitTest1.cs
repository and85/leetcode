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

        [TestCase("YazaAay", "aAa")]
        [TestCase("Bb", "Bb")]
        [TestCase("C", "")]
        [TestCase("dDzeE", "dD")]
        [TestCase("", "")]
        [TestCase(null, "")]
        public void Test1(string s, string expected)
        {
            var solution = new Solution();

            string actual = solution.longestNiceSubstring(s);

            Assert.AreEqual(expected, actual);
        }
    }
}