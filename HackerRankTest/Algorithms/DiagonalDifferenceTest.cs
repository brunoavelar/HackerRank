using HackerRank.Algorithms;
using NUnit.Framework;

namespace HackerRankTest.Algorithms
{
    [TestFixture]
    public class DiagonalDifferenceTest
    {
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

            var output = DiagonalDifference.Execute(values);

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

            var output = DiagonalDifference.Execute(values);

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

            var output = DiagonalDifference.Execute(values);

            Assert.AreEqual(expected, output);
        }
    }
}
