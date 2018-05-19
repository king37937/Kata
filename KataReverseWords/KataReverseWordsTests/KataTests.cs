using KataReverseWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KataReverseWords.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [TestCase("This", ExpectedResult = "sihT")]
        [TestCase("a", ExpectedResult = "a")]
        [TestCase("pen", ExpectedResult = "nep")]
        public string TestSingleWord(string wordToReverse)
        {
            var target = new Kata();
            return target.ReverseWords(wordToReverse);
        }
    }
}