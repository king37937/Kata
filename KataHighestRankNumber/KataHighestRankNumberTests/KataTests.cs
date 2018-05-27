using KataHighestRankNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace KataHighestRankNumber.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [TestCase(new[] { 1 }, ExpectedResult = 1)]
        [TestCase(new[] { 10 }, ExpectedResult = 10)]
        public int Test_SingleElement(int[] array)
        {
            var target = new Kata();
            return target.HighestRank(array);
        }
    }
}