using System;
using NUnit.Framework;

namespace KataPlayWithTwoStrings.Tests
{
    [TestFixture]
    public class KataPlayWithTwoStringsTests
    {
        [Test]
        public void TestWorkOnStrings_Input_a_b_Should_Return_ab()
        {
            //arrange
            var stringA = "a";
            var stringB = "b";
            var expected = "ab";
            var target = new PlayWithTwoStrings();

            //act
            var actual = target.WorkOnStrings(stringA, stringB);

            //acturl
            Assert.AreEqual(expected, actual);
        }
    }
}
