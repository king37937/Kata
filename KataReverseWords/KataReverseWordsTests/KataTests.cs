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
        public string Test_Single_Word(string wordToReverse)
        {
            var target = new Kata();
            return target.ReverseWords(wordToReverse);
        }

        [TestCase("This a", ExpectedResult = "sihT a")]
        [TestCase("a pen", ExpectedResult = "a nep")]
        public string Test_Two_Words(string wordToReverse)
        {
            var target = new Kata();
            return target.ReverseWords(wordToReverse);
        }

        [TestCase("This a pen", ExpectedResult = "sihT a nep")]
        [TestCase("Hello everyone, nice to meet you.", ExpectedResult = "olleH ,enoyreve ecin ot teem .uoy")]
        public string Test_Three_or_More_Words(string wordToReverse)
        {
            var target = new Kata();
            return target.ReverseWords(wordToReverse);
        }

        [TestCase("This  a pen", ExpectedResult = "sihT  a nep")]
        [TestCase("This  a  pen", ExpectedResult = "sihT  a  nep")]
        public string Test_Double_Space(string wordToReverse)
        {
            var target = new Kata();
            return target.ReverseWords(wordToReverse);
        }

    }
}