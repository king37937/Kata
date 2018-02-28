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
            //arrange
            var nextSmallerNumber = new NextSmallerNumber.NextSmallerNumber();

            //act
            var actual = nextSmallerNumber.FindNext(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        
    }
}
