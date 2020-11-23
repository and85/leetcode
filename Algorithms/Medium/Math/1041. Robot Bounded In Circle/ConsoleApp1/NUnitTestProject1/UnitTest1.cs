using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCase("GGLLGG", true)]
        [TestCase("GG", false)]
        [TestCase("GL", true)]
        public void Test(string instructions, bool expcected)
        {
            // arrange
            var solution = new Solution();

            // act
            bool actual = solution.IsRobotBounded(instructions);

            // assert
            Assert.AreEqual(expcected, actual);
        }
    }
}