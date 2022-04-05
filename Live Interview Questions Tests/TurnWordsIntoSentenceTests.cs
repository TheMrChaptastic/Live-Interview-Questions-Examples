using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class TurnWordsIntoSentenceTests
    {
        private QTurnWordsIntoSentence _wordsIntoSentence;
        [SetUp]
        public void SetUp()
        {
            _wordsIntoSentence = new QTurnWordsIntoSentence();
        }

        [Test]
        [TestCase(null)]
        public void ShouldReturnEmpty(string[] value)
        {
            var result = _wordsIntoSentence.WordsIntoSentence(value);

            Assert.AreEqual("", result, "Should return empty string.");
        }

        [Test]
        [TestCase(new string[] { "Hello", "World!" }, "Hello World!")]
        [TestCase(new string[] { "Chappy", "doesn't", "know", "code." }, "Chappy doesn't know code.")]
        [TestCase(new string[] { "Wanna", "go", "fishing?"}, "Wanna go fishing?")]
        public void ShouldReturnSentence(string[] value, string expected)
        {
            var result = _wordsIntoSentence.WordsIntoSentence(value);

            Assert.AreEqual(expected, result, $"Should be: {expected}");
        }
    }
}
