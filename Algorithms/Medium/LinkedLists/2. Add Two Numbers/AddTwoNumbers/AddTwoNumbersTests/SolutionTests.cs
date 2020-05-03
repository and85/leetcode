using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddTwoNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            // arrange
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            // act
            var actual = new Solution().AddTwoNumbers(l1, l2);

            // assert
        }

        [TestMethod()]
        public void AddTwoNumbersTest2()
        {
            // arrange
            ListNode l1 = new ListNode(1, new ListNode(8));
            ListNode l2 = new ListNode(0);

            // act
            var actual = new Solution().AddTwoNumbers(l1, l2);

            // assert
        }

        [TestMethod()]
        public void AddTwoNumbersTest3()
        {
            // arrange
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9, new ListNode(9));

            // act
            var actual = new Solution().AddTwoNumbers(l1, l2);

            // assert
        }
    }
}