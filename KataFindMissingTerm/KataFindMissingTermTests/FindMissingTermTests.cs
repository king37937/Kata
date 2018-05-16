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
            var list = new List<int>{1,3,5,9};
            var target = new FindMissingTerm();
            var expected = 7;

            var actual = target.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }

    }
}