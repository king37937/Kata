using System;
using NUnit.Framework;
using KataGetMiddleCharacter;

namespace KataGetMiddleCharacterTests
{
    [TestFixture]
    public class GetMiddleCharacterTests
    {
        [Test]
        public void input_empty_should_return_empty()
        {
            var target = new StringProceor();
            var str = "";
            var expected = "";
            var actual = target.GetMiddle(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("test", "es")]
        [TestCase("tESt", "ES")]
        [TestCase("te", "te")]
        [TestCase("testtesttesttesttesttesttesttesttesttest", "tt")]
        [TestCase("123456", "34")]
        public void length_even_should_return_middle_two_char(string s, string expected)
        {
            var target = new StringProceor();
            var actual = target.GetMiddle(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("a", "a")]
        [TestCase("A", "A")]
        [TestCase("testing", "t")]
        [TestCase("TeStInG", "t")]
        public void length_odd_should_return_middle_two_char(string s, string expected)
        {
            var target = new StringProceor();
            var actual = target.GetMiddle(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
