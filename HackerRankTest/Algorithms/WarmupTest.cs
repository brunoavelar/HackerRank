using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Algorithms
{
    [TestFixture]
    public class WarmupTest
    {
        [Test]
        public void VeryBigSumTestDefaultTestCase()
        {
            var bigInts = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            var expected = 5000000015;

            var result = Warmup.VeryBigSum(bigInts);

            result.Should().Be(expected);
        }

        [Test]
        public void StaircaseDefault()
        {
            var steps = 6;

            var expected = new[] { "     #", "    ##", "   ###", "  ####", " #####", "######" };
            var output = Warmup.Staircase(steps);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void StaircaseOneStep()
        {
            var steps = 1;

            var expected = new[] { "#" };
            var output = Warmup.Staircase(steps);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void PlusMinusTestDefaulTestCase()
        {
            var ints = new int[] { -4, 3, -9, 0, 4, 1 };
            var expected = new decimal[] { 0.500000m, 0.333333m, 0.166667m };

            var result = Warmup.PlusMinus(ints);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DiagonalDifferencePositive()
        {
            int[][] values =
            {
                new[] { 11, 2, 4 },
                new[] { 4, 5, 6 },
                new[] { 10, 8, 12 },
            };

            var expected = 9;

            var output = Warmup.DiagonalDifference(values);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void DiagonalDifferenceNegative()
        {
            int[][] values =
            {
                new[] { 11, 2, 4 },
                new[] { 4, 5, 6 },
                new[] { 10, 8, -12 },
            };
            var expected = 15;

            var output = Warmup.DiagonalDifference(values);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void DiagonalDifferenceFiveByFive()
        {
            int[][] values =
            {
                new[] { 1, 2, 3, 4, 5 },
                new[] { 6, 7, 8, 9, 10 },
                new[] { 11, 12, 13, 14, 15 },
                new[] { 16, 17, 18, 19, 20 },
                new[] { 21, 22, 23, 24, 25 }
            };
            var expected = 0;

            var output = Warmup.DiagonalDifference(values);

            Assert.AreEqual(expected, output);
        }
        [Test]
        public void CompareTripletsTie()
        {
            int a0 = 5;
            int a1 = 6;
            int a2 = 7;
            int b0 = 3;
            int b1 = 6;
            int b2 = 10;

            var expected = new[] { 1, 1 };

            var output = Warmup.CompareTriplets(a0, a1, a2, b0, b1, b2);

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

            var output = Warmup.CompareTriplets(a0, a1, a2, b0, b1, b2);

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

            var output = Warmup.CompareTriplets(a0, a1, a2, b0, b1, b2);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TimeConversionAm()
        {
            var time = "03:00:00AM";
            var expected = "03:00:00";

            var result = Warmup.TimeConversion(time);

            result.Should().Be(expected);
        }

        [Test]
        public void TimeConversionPm()
        {
            var time = "03:00:00PM";
            var expected = "15:00:00";

            var result = Warmup.TimeConversion(time);

            result.Should().Be(expected);
        }

        [Test]
        public void TimeConversionMidDay()
        {
            var time = "12:00:00PM";
            var expected = "12:00:00";

            var result = Warmup.TimeConversion(time);

            result.Should().Be(expected);
        }

        [Test]
        public void TimeConversionMidNight()
        {
            var time = "12:00:00AM";
            var expected = "00:00:00";

            var result = Warmup.TimeConversion(time);

            result.Should().Be(expected);
        }

        [Test]
        public void MinMaxSumDefaultTestCase()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var expected = new[] { 10, 14 };

            var result = Warmup.MinMaxSum(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MinMaxSumEqualMin()
        {
            var numbers = new[] { 1, 2, 3, 4, 1 };
            var expected = new[] { 7, 10 };

            var result = Warmup.MinMaxSum(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MinMaxSumEqualMax()
        {
            var numbers = new[] { 5, 2, 3, 4, 5 };
            var expected = new[] { 14, 17 };

            var result = Warmup.MinMaxSum(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MinMaxSumResultLong()
        {
            var numbers = new[] { 2147483644, 2147483643, 2147483646, 2147483645, 2147483647 };
            var expected = new[] { 8589934578, 8589934582 };

            var result = Warmup.MinMaxSum(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}
