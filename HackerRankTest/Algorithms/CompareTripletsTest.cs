using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Algorithms
{
    [TestFixture]
    public class CompareTripletsTest
    {
        [Test]
        public void CompareTripletsTie()
        {
            int a0 = 5;
            int a1 = 6;
            int a2 = 7;
            int b0 = 3;
            int b1 = 6;
            int b2 = 10;

            var expected = new[]{ 1, 1 };

            var output = CompareTriplets.Execute(a0, a1, a2, b0, b1, b2);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void CompareTripletsAWins()
        {
            int a0 = 8;
            int a1 = 9;
            int a2 = 10;
            int b0 = 8;
            int b1 = 9;
            int b2 = 9;

            var expected = new[] { 1, 0 };

            var output = CompareTriplets.Execute(a0, a1, a2, b0, b1, b2);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void CompareTripletsBWins()
        {
            int a0 = 8;
            int a1 = 9;
            int a2 = 9;
            int b0 = 8;
            int b1 = 9;
            int b2 = 10;

            var expected = new[] { 0, 1 };

            var output = CompareTriplets.Execute(a0, a1, a2, b0, b1, b2);

            Assert.AreEqual(expected, output);
        }
    }
}
