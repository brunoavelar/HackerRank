using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Algorithms
{
    [TestFixture]
    public class StaircaseTest
    {
        [Test]
        public void StaircaseDefault()
        {
            var steps = 6;

            var expected = new[] { "     #", "    ##", "   ###", "  ####", " #####", "######" };
            var output = Staircase.Execute(steps);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void StaircaseOneStep()
        {
            var steps = 1;

            var expected = new[] { "#" };
            var output = Staircase.Execute(steps);

            Assert.AreEqual(expected, output);
        }
    }
}
