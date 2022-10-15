using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests.Stage_1_Tests
{
    public class ReverseAStringTests
    {
        private QReverseAString _reverseString = new QReverseAString();

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ShouldBeEmpty(string str)
        {
            var result = _reverseString.ReverseString(str);

            Assert.AreEqual("", result);
        }
        [Test]
        [TestCase("test","tset")]
        [TestCase("another one","eno rehtona")]
        [TestCase("Chicken", "nekcihC")]
        [TestCase("winner", "renniw")]
        public void ShouldBeReversed(string str, string expected)
        {
            var result = _reverseString.ReverseString(str);

            Assert.AreEqual(expected, result);
        }
    }
}
