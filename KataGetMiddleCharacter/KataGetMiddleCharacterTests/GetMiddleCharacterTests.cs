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
    }
}
