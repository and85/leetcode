using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [DataTestMethod()]
        [DataRow(5, 4)]
        public void FirstBadVersionTest(int n, int expected)
        {
            // arrange

            // act
            var solution = new Solution();
            int actual = solution.FirstBadVersion(n);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}





