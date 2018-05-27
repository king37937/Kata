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

        [TestCase(new[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 }, ExpectedResult = 12)]
        public int Test_SampleCase(int[] array)
        {
            var target = new Kata();
            return target.HighestRank(array);
        }

        [TestCase(new[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 }, ExpectedResult = 12)]
        [TestCase(new[] { 12, 10, 8, 12, 7, 7, 7, 10, 12, 10 }, ExpectedResult = 12)]
        public int Test_SameCount_Should_Return_Highest_Number(int[] array)
        {
            var target = new Kata();
            return target.HighestRank(array);
        }


    }
}