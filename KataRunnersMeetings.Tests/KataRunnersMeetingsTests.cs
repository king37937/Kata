using System;
using NUnit.Framework;

namespace KataRunnersMeetings.Tests
{
    [TestFixture]
    public class KataRunnersMeetingsTests
    {
        [TestCase(new[] { 1, 2 }, new[] { 1, 1 }, -1)]
        [TestCase(new[] { 1, 2 }, new[] { 2, 1 }, 2)]
        public void CalculateRunningsMeetingsTest(int[] startPosition, int[] speed, int expected)
        {
            //arrange
            var target = new RunnersMeetings();

            //act
            var actual = target.CalculateRunningsMeetings(startPosition, speed);

            //actual
            Assert.AreEqual(expected, actual);
        }
    }
}
