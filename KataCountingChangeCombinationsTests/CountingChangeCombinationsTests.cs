﻿using KataCountingChangeCombinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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

        [TestCase(4, new[] { 1, 2 }, 3)]
        [TestCase(10, new[] { 5, 2, 3 }, 4)]
        public void CountCombinationsTest_SampleCase(int money, int[] coins, int expected)
        {
            //arrange

            //act
            var acturl = CountingChangeCombinations.CountCombinations(money, coins);

            //assert
            Assert.AreEqual(expected, acturl);
        }

        [TestCase(10, new[] { 1 }, 1)]
        [TestCase(10, new[] { 2 }, 1)]
        [TestCase(10, new[] { 5 }, 1)]
        public void CountCombinationsTest_OneCoin_Should_Return_One(int money, int[] coins, int expected)
        {
            //arrange

            //act
            var acturl = CountingChangeCombinations.CountCombinations(money, coins);

            //assert
            Assert.AreEqual(expected, acturl);
        }
    }
}