using Live_Interview_Questions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions_Tests.Stage_3_Tests
{
    public class MaximumProfitsTests
    {
        private QMaximumProfits _maximumProfits = new QMaximumProfits();

        [Test]

        [TestCase(new[] { 7, 6, 4, 3, 1 })]
        [TestCase(new[] { 10, 7, 5, 3, 1 })]
        public void ShouldReturnZero(int[] arr)
        {
            var result = _maximumProfits.MaxProfit(arr);

            Assert.AreEqual(0, result);
        }

        [Test]
        [TestCase(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new[] { 7, 3, 20, 5, 12 }, 17)]
        [TestCase(new[] { 19, 3, 4, 6, 1 }, 3)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new[] { 1, 3, 2, 7, 3 }, 6)]
        public void ReturnTwoIndexes(int[] arr, int expected)
        {
            var result = _maximumProfits.MaxProfit(arr);

            Assert.AreEqual(expected, result);
        }
    }
}
