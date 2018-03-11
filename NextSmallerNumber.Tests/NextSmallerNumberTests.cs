using System;
using NUnit.Framework;
using NextSmallerNumber;

namespace Kata.Tests
{
    [TestFixture]
    public class NextSmallerNumberTests
    {
        [TestCase(1,-1)]
        [TestCase(0, -1)]
        [TestCase(9, -1)]
        public void One_Digit_Should_Return_NegativeOne(int input, int expected)
        {
            NextSmallerNumberShouldBe(input, expected);
        }

        [TestCase(21, 12)]
        public void Two_Digits_Should_Return_Smaller(int input, int expected)
        {
            NextSmallerNumberShouldBe(input, expected);
        }

        [TestCase(231, 213)]
        [TestCase(312, 231)]
        [TestCase(3214,3142)]
        [TestCase(4948900009, 4948099000)]
        [TestCase(651257, 627551)]
        [TestCase(51226262651257, 51226262627551)]
        [TestCase(1956584962552167, 1956584962551762)]
        public void MoreThenTwoDigits_Should_Return_Smaller(long input, long expected)
        {
            NextSmallerNumberShouldBe(input, expected);
        }

        [TestCase(1027, -1)]
        public void SmallestNumberWithZeroLeading_Should_Return_NegativeOne(long input, long expected)
        {
            NextSmallerNumberShouldBe(input, expected);
        }

        [TestCase(111, -1)]
        [TestCase(135, -1)]
        public void NoSmallerNumber_Should_Return_NegativeOne(long input, long expected)
        {
            NextSmallerNumberShouldBe(input, expected);
        }

        private void NextSmallerNumberShouldBe(long input, long expected)
        {
            //arrange
            var nextSmallerNumber = new NextSmallerNumber.NextSmallerNumber();

            //act
            var actual = nextSmallerNumber.FindNext(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
