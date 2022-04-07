using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class SumOfTwoIndexesToTargetTests
    {
        private QSumOfTwoIndexesToTarget _sumTwoToTargetNumber = new QSumOfTwoIndexesToTarget();

        [Test]
        [TestCase(new[] { 1, 2, 3 }, 5, new[] { 1, 2 })]
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
        [TestCase(new[] {72, 19, 74, 66, 86, 2, 42, 83, 97, 83, 58, 52, 7, 79, 77, 69, 35, 31, 57, 59, 80, 35, 19, 64, 99, 99, 14, 86, 67, 75, 20, 17, 94, 63, 79, 4, 65, 51, 54, 84, 82, 2, 99, 77, 8, 48, 74, 64, 86, 81, 20, 50, 96, 99, 10, 57, 57, 75, 85, 8, 31, 7, 83, 92, 80, 17, 19, 52, 92, 50, 32, 37, 44, 30, 100, 56, 19, 87, 71, 14, 3, 56, 92, 46, 82, 40, 63, 49, 28, 84, 92, 31, 60, 92, 79, 49, 19, 49, 6, 2 }, 68, new[] { 3, 5 })]
        public void ReturnTwoIndexes(int[] arr, int target, int[] expected)
        {
            var result = _sumTwoToTargetNumber.SumOfTwoIndexesEqualTarget(arr, target);

            Assert.AreEqual(expected, result);
        }
    }
}
