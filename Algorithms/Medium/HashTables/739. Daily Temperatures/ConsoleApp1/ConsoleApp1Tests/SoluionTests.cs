using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class SoluionTests
    {
        [TestMethod()]
        public void DailyTemperaturesTest1()
        {
            // arrange
            var input = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            var expected = new int[] {1, 1, 4, 2, 1, 1, 0, 0};

            // act
            var solution = new Soluion();
            var acual = solution.DailyTemperatures(input);

            // assert
            Assert.AreEqual(expected, acual);
        }
    }
}
