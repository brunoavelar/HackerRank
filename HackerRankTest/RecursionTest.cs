using CrackingTheCodeInterview;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace CrackingTheCodeInterviewTests
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