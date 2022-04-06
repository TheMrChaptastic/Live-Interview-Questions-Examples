using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class SumTwoToTargetNumberTests
    {
        private QSumTwoToTargetNumber _sumTwoToTargetNumber = new QSumTwoToTargetNumber();

        [Test]
        [TestCase(new[] { 1, 2, 3 }, 5)]
        [TestCase(new[] { 1, 2, 3 }, 3)]
        [TestCase(new[] { 7, 3, 20 }, 10)]
        [TestCase(new[] { 7, 3, 20 }, 27)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 3)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 9)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 10)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 14)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 2)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 4)]
        [TestCase(new[] { 5, -2, 4, 4, 8 }, 8)]
        [TestCase(new[] { 5, -2, 4, 4 }, 8)]
        [TestCase(new[] { 3, -3 }, 0)]
        [TestCase(new[] { 3, -3, 3, -3 }, -6)]
        [TestCase(new[] { 3, -3, 3, -3 }, 0)]
        public void ShouldReturnTrue(int[] arr, int target)
        {
            var result = _sumTwoToTargetNumber.TwoDifferentElementsInArrayCanSumToTargetNumber(arr, target);

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 15)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, 0)]
        [TestCase(new[] { 5, -2, 4, 6, 8 }, -2)]
        [TestCase(new[] { 4 }, 8)]
        [TestCase(new[] { 4 }, 4)]
        [TestCase(new int[] { }, 1)]
        public void ShouldReturnFalse(int[] arr, int target)
        {
            var result = _sumTwoToTargetNumber.TwoDifferentElementsInArrayCanSumToTargetNumber(arr, target);

            Assert.IsFalse(result);
        }
    }
}
