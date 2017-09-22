using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Algorithms
{
    [TestFixture]
    public class VeryBigSumTest
    {
        [Test]
        public void DefaultTestCase()
        {
            var bigInts = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            var expected = 5000000015;

            var result = VeryBigSum.Execute(bigInts);

            result.Should().Be(expected);
        }
    }
}
