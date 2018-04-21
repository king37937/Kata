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

        [Test]
        public void TestWorkOnStrings_Input_ab_bc_Should_Return_aBBc()
        {
            //arrange
            var stringA = "ab";
            var stringB = "bc";
            var expected = "aBBc";
            var target = new PlayWithTwoStrings();

            //act
            var actual = target.WorkOnStrings(stringA, stringB);

            //acturl
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestWorkOnStrings_Input_ab_aba_Should_Return_aBABA()
        {
            //arrange
            var stringA = "ab";
            var stringB = "aba";
            var expected = "aBABA";
            var target = new PlayWithTwoStrings();

            //act
            var actual = target.WorkOnStrings(stringA, stringB);

            //acturl
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestWorkOnStrings_Input_abcdeFgtrzw_defgGgfhjkwqe_Should_Return_abcDeFGtrzWDEFGgGFhjkWqE()
        {
            //arrange
            var stringA = "abcdeFgtrzw";
            var stringB = "defgGgfhjkwqe";
            var expected = "abcDeFGtrzWDEFGgGFhjkWqE";
            var target = new PlayWithTwoStrings();

            //act
            var actual = target.WorkOnStrings(stringA, stringB);

            //acturl
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DictTest()
        {
            (new PlayWithTwoStrings()).DictTest();
        }
    }
}
