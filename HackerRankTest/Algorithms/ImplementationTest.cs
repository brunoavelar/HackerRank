using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Algorithms
{
    [TestFixture]
    public class ImplementationTest
    {
        [Test]
        public void RoundUpGradesDefaultTestCase()
        {
            var numbers = new[] { 73, 67, 38, 33 };
            var expected = new[] { 75, 67, 40, 33 };

            var result = Implementation.RoundUpGrades(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}
