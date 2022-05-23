using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class ReturnAnArrayTests
    {
        private QReturnAnArray _returnAnArray = new QReturnAnArray();

        [Test]
        public void ShouldBeEmptyStringArray()
        {
            var result = _returnAnArray.ReturnEmptyStringArray();

            Assert.AreEqual(new string[0], result);
        }

        [Test]
        public void ShouldBeEmptyIntArray()
        {
            var result = _returnAnArray.ReturnEmptyIntArray();

            Assert.AreEqual(new int[0], result);
        }

        [Test]
        [TestCase(1, new int[] { 1 })]
        [TestCase(3, new int[] { 1, 2, 3 })]
        [TestCase(5, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(20, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })]
        public void ShouldBePopulatedFrom1ToN(int n, int[] expected)
        {
            var result = _returnAnArray.ReturnIntArrayFrom1ToN(n);

            Assert.AreEqual(expected, result);
        }
    }
}
