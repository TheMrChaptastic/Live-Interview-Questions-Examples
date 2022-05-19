using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests
{
    public class FizzBuzzTests
    {
        private QFizzBuzz _fizzBuzz = new QFizzBuzz();

        [Test]
        [TestCase(2, "2")]
        [TestCase(7, "7")]
        [TestCase(97, "97")]
        public void ShouldReturnNumberAsString(int str, string expected)
        {
            var result = _fizzBuzz.FizzBuzz(str);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(3)]
        [TestCase(9)]
        [TestCase(27)]
        public void ShouldReturnFizz(int str)
        {
            var result = _fizzBuzz.FizzBuzz(str);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void ShouldReturnBuzz(int str)
        {
            var result = _fizzBuzz.FizzBuzz(str);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        [TestCase(15)]
        [TestCase(45)]
        [TestCase(90)]
        public void ShouldReturnFizzBuzz(int str)
        {
            var result = _fizzBuzz.FizzBuzz(str);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
