using KataCountingChangeCombinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KataCountingChangeCombinations.Tests
{
    [TestFixture]
    public class CountingChangeCombinationsTests
    {
        [Test()]
        public void CountCombinationsTest_NoChange_Should_Return_0()
        {
            //arrange
            var money = 11;
            var coins = new [] {5, 7};
            var expected = 0;

            //act
            var acturl = CountingChangeCombinations.CountCombinations(money, coins);

            //assert
            Assert.AreEqual(expected, acturl);
        }

        [Test()]
        public void CountCombinationsTest_SampleCase()
        {
            //arrange
            var money = 4;
            var coins = new[] { 1, 2 };
            var expected = 3;

            //act
            var acturl = CountingChangeCombinations.CountCombinations(money, coins);

            //assert
            Assert.AreEqual(expected, acturl);
        }
    }
}