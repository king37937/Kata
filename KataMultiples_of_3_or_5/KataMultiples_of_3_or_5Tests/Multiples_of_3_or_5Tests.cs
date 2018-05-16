using NUnit.Framework;

namespace KataMultiples_of_3_or_5.Tests
{
    [TestFixture]
    public class Multiples_of_3_or_5Tests
    {
        [TestCase(10, 23)]
        [TestCase(3, 0)]
        [TestCase(4, 3)]
        [TestCase(6, 8)]
        [TestCase(16, 60)]
        public void SampleCase(int n, int expected)
        {
            var target = new Multiples_of_3_or_5();

            var actual = target.Sum(n);

            Assert.AreEqual(expected, actual);
        }

       


    }
}