using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataMultiples_of_3_or_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMultiples_of_3_or_5.Tests
{
    [TestClass()]
    public class Multiples_of_3_or_5Tests
    {
        [TestMethod()]
        public void SampleCase()
        {
            var target = new Multiples_of_3_or_5();
            var number = 10;
            var expected = 23;

            var actual = target.Sum(number);

            Assert.AreEqual(expected, actual);
        }
    }
}