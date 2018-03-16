using System;
using NUnit.Framework;

namespace KataRunnersMeetings.Tests
{
    [TestFixture]
    public class KataRunnersMeetingsTests
    {
        [TestCase(new[] { 1, 2 }, new[] { 1, 1 }, -1)]
        [TestCase(new[] { 1, 2 }, new[] { 2, 1 }, 2)]
        [TestCase(new[] { 2, 1 }, new[] { 1, 2 }, 2)]
        [TestCase(new[] { 1, 4, 2 }, new[] { 27, 18, 24 }, 3)]
        [TestCase(new[] { 1, 4, 2 }, new[] { 5, 6, 2 }, 2)]
        [TestCase(new[] { 1, 1000 }, new[] { 23, 22 }, 2)]
        [TestCase(new[] { -32, 31, 49, 7, 21, 14, -5, -10, 25, 48, 44, -11, 45 }, new[] { 26, 11, 30, 23, 11, 8, 19, 20, 11, 27, 10, 23, 18 }, 2)]
        public void CalculateRunningsMeetingsTest(int[] startPosition, int[] speed, int expected)
        {
            //arrange
            var target = new RunnersMeetings();

            //act
            var actual = target.CalculateRunnersMeetings(startPosition, speed);

            //actual
            Assert.AreEqual(expected, actual);
        }
    }
}
