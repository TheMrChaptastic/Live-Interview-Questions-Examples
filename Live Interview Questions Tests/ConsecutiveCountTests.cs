using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class ConsecutiveCountTests
    {
        private QConsecutiveCount _consecutiveCount = new QConsecutiveCount();

        [Test]
        [TestCase(null)]
        [TestCase(new int[0])]
        public void ShouldReturn0(int[] value)
        {
            var result = _consecutiveCount.HighestConsecutiveCount(value);

            Assert.AreEqual(0, result, "The result should have been 0.");
        }

        [Test]
        [TestCase(1)]
        [TestCase(1,2,3,4,5,6,7,8,9)]
        public void ShouldReturn1(int[] value)
        {
            var result = _consecutiveCount.HighestConsecutiveCount(value);

            Assert.AreEqual(1, result, "The result should have been 1.");
        }

        [Test]
        [TestCase(1, 1, 2, 2)]
        [TestCase(1, 2, 2, 4, 5, 6, 7, 8, 9)]
        public void ShouldReturn2(int[] value)
        {
            var result = _consecutiveCount.HighestConsecutiveCount(value);

            Assert.AreEqual(2, result, "The result should have been 2.");
        }

        [Test]
        [TestCase(1, 2, 2, 2)]
        [TestCase(1, 2, 2, 4, 5, 5, 5, 8, 9)]
        public void ShouldReturn3(int[] value)
        {
            var result = _consecutiveCount.HighestConsecutiveCount(value);

            Assert.AreEqual(3, result, "The result should have been 3.");
        }
    }
}