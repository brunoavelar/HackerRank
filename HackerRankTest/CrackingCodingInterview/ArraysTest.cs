using FluentAssertions;
using HackerRank.CrackingCodingInterview;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace HackerRankTest.CrackingCodingInterview
{
    [TestFixture]
    class ArraysTests
    {
        [Test]
        public void LeftRotationTest()
        {
            var input = new[] { 1, 2, 3, 4, 5 };
            var expected = new[] { 4, 5, 1, 2, 3 };
            var rotations = 3;

            var output = Arrays.ShiftLeft(input, rotations);
            Assert.AreEqual(expected, output);
        }
    }
}