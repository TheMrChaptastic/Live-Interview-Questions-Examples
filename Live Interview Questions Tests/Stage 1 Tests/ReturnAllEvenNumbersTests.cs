using Live_Interview_Questions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions_Tests
{
    public class ReturnAllEvenNumbersTests
    {
        private QReturnAllEvenNumbers _returnAnArray = new QReturnAllEvenNumbers();

        [Test]
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-100)]
        [TestCase(null)]
        public void ShouldBeEmptyIntList(int n)
        {
            var result = _returnAnArray.ReturnListEvensFrom1ToN(n);

            Assert.AreEqual(new List<int>(), result);
        }

        [Test]
        [TestCase(2, new int[] { 2 })]
        [TestCase(6, new int[] { 2, 4, 6 })]
        [TestCase(10, new int[] { 2, 4, 6, 8, 10 })]
        [TestCase(20, new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 })]
        [TestCase(50, new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50 })]
        public void ShouldBePopulatedFrom1ToN(int n, int[] expected)
        {
            var result = _returnAnArray.ReturnListEvensFrom1ToN(n);

            Assert.AreEqual(expected.ToList(), result);
        }
    }
}
