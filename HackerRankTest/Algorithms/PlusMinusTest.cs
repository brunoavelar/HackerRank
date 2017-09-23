using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Algorithms
{
    [TestFixture]
    public class PlusMinusTest
    {
        [Test]
        public void PlusMinusTestDefaulTestCase()
        {
            var ints = new int[] { -4, 3, -9, 0, 4, 1 };
            var expected = new decimal[] { 0.500000m, 0.333333m, 0.166667m };

            var result = PlusMinus.Execute(ints);

            Assert.AreEqual(expected, result);
        }
    }
}
