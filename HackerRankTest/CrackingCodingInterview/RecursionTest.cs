using FluentAssertions;
using HackerRank.CrackingCodingInterview;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace HackerRankTest.CrackingCodingInterview
{
    [TestFixture]
    class RecursionTest
    {
        [Test]
        public void FibonacciTest()
        {
            var expected = 8;
            var output = Recursion.Fibonacci(6);

            Assert.AreEqual(expected, output);
        }

    }
}