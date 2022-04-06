using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class SumOfTwoIndexesToTargetTests
    {
        private QSumTwoToTargetNumber _sumTwoToTargetNumber = new QSumTwoToTargetNumber();

        [Test]
        [TestCase(new[] { 1, 2, 3 }, 5, new[] { 0, 2 })]
        [TestCase(new[] { 1, 2, 3 }, 3, new[] { 0, 1 })]
        [TestCase(new[] { 7, 3, 20 }, 10, new[] { 0, 1 })]
        [TestCase(new[] { 7, 3, 20 }, 27, new[] { 0, 2 })]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 3, new[] { 0, 1 })]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 9, new[] { 0, 2 })]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 10, new[] { 2, 3 })]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 14, new[] { 3, 4 })]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 2, new[] { 1, 2 })]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 4, new[] { 1, 3 })]
        [TestCase(new[] { 5, -2, 4, 4, 8 }, 8, new[] { 2, 3 })]
        [TestCase(new[] { 5, -2, 4, 4 }, 8, new[] { 2, 3 })]
        [TestCase(new[] { 3, -3 }, 0, new[] { 0, 1 })]
        [TestCase(new[] { 3, -3, 3, -3 }, -6, new[] { 1, 3 })]
        [TestCase(new[] { 3, -3, 3, -3 }, 0, new[] { 0, 1 })]
        [TestCase(new[] { 3, 11, 13, 1, 2, 11, 16, -100, 17, 192, 43, -1999, 342, 3455, 24, 1, 123, 51, 45, 2, 2, 2, 2, 2, 2, 2, 11, 16, 0, 0, 10 }, 15, new[] { 2, 4 })]
        public void ReturnTwoIndexes(int[] arr, int target, int[] expected)
        {
            var result = _sumTwoToTargetNumber.TwoDifferentElementsInArrayCanSumToTargetNumber(arr, target);

            Assert.IsTrue(result);
        }
    }
}
