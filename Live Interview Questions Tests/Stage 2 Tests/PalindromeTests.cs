using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class PalindromeTests
    {
        private QPalindrome _palindrome = new QPalindrome();

        [Test]
        [TestCase("result")]
        [TestCase("not again")]
        [TestCase("news")]
        [TestCase("palindrome")]
        public void ShouldReturnFalse(string str)
        {
            var result = _palindrome.PalindromeCheck(str);

            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("racecar")]
        [TestCase("radar")]
        [TestCase("wow")]
        [TestCase("madam")]
        public void ShouldReturnTrue(string str)
        {
            var result = _palindrome.PalindromeCheck(str);

            Assert.IsTrue(result);
        }
    }
}
