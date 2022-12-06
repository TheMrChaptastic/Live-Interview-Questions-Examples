using Live_Interview_Questions;
using NUnit.Framework;

namespace Live_Interview_Questions_Tests.Stage_2_Tests
{
    public class FibonacciTests
    {
        private QFibonacci _fibonacci = new QFibonacci();

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-100)]
        public void ShouldReturn0(int value)
        {
            var result = _fibonacci.FibonacciNumber(value);

            Assert.AreEqual(0, result);
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(5, 3)]
        [TestCase(6, 5)]
        [TestCase(10, 34)]
        [TestCase(41,102334155)]
        public void ShouldReturnNumber(int value, int expected)
        {
            var result = _fibonacci.FibonacciNumber(value);

            Assert.AreEqual(expected, result);
        }
    }
}