using Live_Interview_Questions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions_Tests.Stage_2_Tests
{
    public class MergeSortTwoListsTests
    {
        private QMergeSortTwoLists _sumTwoToTargetNumber = new QMergeSortTwoLists();

        [Test]
        public void ShouldReturnEmptyList()
        {
            var result = _sumTwoToTargetNumber.MergeSortTwoLists(new List<int>(), new List<int>());

            Assert.AreEqual(new List<int>(), result);
        }

        [Test]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 1, 2, 2, 3, 3 })]
        [TestCase(new[] { 3, 2, 1 }, new[] { 1, 2, 3 }, new[] { 1, 1, 2, 2, 3, 3 })]
        [TestCase(new[] { 1, 5, 9 }, new[] { 1, 2, 3 }, new[] { 1, 1, 2, 3, 5, 9 })]
        [TestCase(new[] { 21, 1232, 33 }, new[] { 31, 22, 563 }, new[] { 21, 22, 31, 33, 563, 1232 })]
        [TestCase(new[] { 1 }, new[] { 1, 4, 2, 3 }, new[] { 1, 1, 2, 3, 4 })]
        public void ShouldSortMergedLists(int[] arr1, int[] arr2, int[] expected)
        {
            var result = _sumTwoToTargetNumber.MergeSortTwoLists(arr1.ToList(), arr2.ToList());

            Assert.AreEqual(expected, result);
        }
    }
}
