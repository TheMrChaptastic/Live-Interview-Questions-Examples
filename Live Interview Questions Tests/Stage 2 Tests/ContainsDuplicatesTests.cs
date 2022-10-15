using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests.Stage_2_Tests
{
    public class ContainsDuplicatesTests
    {
        private QContainsDuplicates _containsDuplicates = new QContainsDuplicates();

        [Test]
        [TestCase("abbde")]
        [TestCase("cdebe")]
        [TestCase("hello")]
        public void ShouldReturnTrue(string str)
        {
            var result = _containsDuplicates.DuplicatesCheck(str);

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("abcde")]
        [TestCase("cdeab")]
        [TestCase("howdy")]
        public void ShouldReturnFalse(string str)
        {
            var result = _containsDuplicates.DuplicatesCheck(str);

            Assert.IsFalse(result);
        }
    }
}
