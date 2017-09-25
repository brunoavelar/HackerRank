using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
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
        public void ExtraLongFactorialWithOne()
        {
            var expected = 1;
            var result = Implementation.ExtraLongFactorial(1);

            result.Should().Be(expected);
        }

        [Test]
        public void ExtraLongFactorialWithTwo()
        {
            var expected = 2;
            var result = Implementation.ExtraLongFactorial(2);

            result.Should().Be(expected);
        }

        [Test]
        public void ExtraLongFactorialWithThree()
        {
            var expected = 6;
            var result = Implementation.ExtraLongFactorial(3);

            result.Should().Be(expected);
        }

        [Test]
        public void ExtraLongFactorialWithTwentyFive()
        {
            var expected = BigInteger.Parse("15511210043330985984000000");
            var result = Implementation.ExtraLongFactorial(25);

            result.Should().Be(expected);
        }

        [Test]
        public void ExtraLongFactorialPerformanceWithOneHundred()
        {
            var expected = BigInteger.Parse("93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000");

            var timer = new Stopwatch();
            timer.Start();
            var result = Implementation.ExtraLongFactorial(100);
            timer.Stop();

            Debug.WriteLine(timer.Elapsed);

            result.Should().Be(expected);
            timer.Elapsed.Seconds.Should().BeLessThan(1);
        }
    }
}
