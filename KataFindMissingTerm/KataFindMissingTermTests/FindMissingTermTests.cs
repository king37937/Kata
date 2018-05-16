using KataFindMissingTerm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KataFindMissingTerm.Tests
{
    [TestFixture]
    public class FindMissingTermTests
    {
        [Test()]
        public void FindMissingTest_input_1_3_5_9_7_should_return_7()
        {
            var list = new List<int>{ 1, 3, 5, 9};
            var target = new FindMissingTerm();
            var expected = 7;

            var actual = target.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FindMissingTest_missing_term_is_second_item()
        {
            var list = new List<int> { 1, 5, 7, 9, 11 };
            var target = new FindMissingTerm();
            var expected = 3;

            var actual = target.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FindMissingTest_missing_term_is_last_item()
        {
            var list = new List<int> { 1, 3, 5, 7, 9 };
            var target = new FindMissingTerm();
            var expected = 11;

            var actual = target.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FindMissingTest_no_missing_term_should_return_last_item()
        {
            var list = new List<int> { 3, 5, 7, 9 };
            var target = new FindMissingTerm();
            var expected = 11;

            var actual = target.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }
    }
}