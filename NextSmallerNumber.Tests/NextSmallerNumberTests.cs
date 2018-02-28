using System;
using NUnit.Framework;
using NextSmallerNumber;

namespace Kata.Tests
{
    [TestFixture]
    public class NextSmallerNumberTests
    {
        [Test]
        public void One_Digit_Should_Return_NegativeOne()
        {
            //arrange
            var input = 1;
            var expected = -1;
            var nextSmallerNumber = new NextSmallerNumber.NextSmallerNumber();

            //act
            var actual = nextSmallerNumber.FindNext(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
