using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        [DataRow("11", "1", "100")]
        public void AddBinaryTest(string a, string b, string expected)
        {
            // arrange

            // act
            var actual = new Solution().AddBinary(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}