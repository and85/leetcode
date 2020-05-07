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
        [TestMethod()]
        public void DeleteDuplicatesTest()
        {
            // arrange
            ListNode node = new ListNode(1, new ListNode(1, new ListNode(1)));

            // act
            var solution = new Solution().DeleteDuplicates(node);

            // assert
        }
    }
}