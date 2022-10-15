using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests.Stage_3_Tests
{
    public class ThreeStrongReadsTests
    {
        private QThreeStrongReads _threeStrongReads = new QThreeStrongReads();

        [Test]
        [TestCase(new[] { "a", "b", "c", "a", "a", "b", "c", "a", "b", "c", "b" }, new[] { 12, 19, 16, 11, 7, 12, 10, 1, 12, 11, 15 }, "b")]
        [TestCase(new[] { "a", "b", "c", "a", "a", "b", "c", "a", "b", "c", "b" }, new[] { 12, 9, 16, 11, 16, 12, 10, 9, 12, 11, 15 }, "a")]
        [TestCase(new[] { "d", "a", "b", "d", "c", "a", "a", "d", "b", "c", "a", "b", "c", "b" }, new[] { 11, 12, 9, 14, 16, 11, 7, 12, 12, 10, 9, 12, 11, 15 }, "d")]
        public void ThreeStrongReadsTest(string[] ids, int[] strs, string exp)
        {
            var result = _threeStrongReads.FirstToThreeStrongReads(ids, strs);

            Assert.AreEqual(exp, result);
        }
    }
}
