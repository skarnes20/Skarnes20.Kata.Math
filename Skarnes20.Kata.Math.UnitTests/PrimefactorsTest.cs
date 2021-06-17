using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Skarnes20.Kata.Math
{
    public class PrimefactorsTest
    {
        [Theory(DisplayName = "Of Primefactors Unit Tests")]
        [InlineData(1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 2, 2)]
        [InlineData(5, 5)]
        [InlineData(6, 2, 3)]
        [InlineData(7, 7)]
        [InlineData(8, 2, 2, 2)]
        [InlineData(9, 3, 3)]
        public void Of_Number_Expected(int number, params int[] expected)
        {
            var acutal = Primfactors.Of(number);

            Assert.Equal(expected, acutal);
        }

        [Fact(DisplayName = "Of Acceptance test")]
        public void Of_AcceptanceTest()
        {
            var expected = new List<int> { 2, 3, 7, 11, 13, 17, 19, 23, 29 };

            var actual = Primfactors.Of(2 * 3 * 7 * 11 * 13 * 17 * 19 * 23 * 29);

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Of Performance should be good")]
        public void Of_PerformanceTest()
        {
            var timer = new Stopwatch();
            timer.Start();
            Primfactors.Of(int.MaxValue);
            timer.Stop();

            Assert.True(timer.ElapsedMilliseconds < 1000, $"Slow performance, running for {timer.ElapsedMilliseconds / 1000 } sec.");
        }

        [Theory(DisplayName = "Factors Primefactors Unit Tests")]
        [InlineData(1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 2, 2)]
        [InlineData(5, 5)]
        [InlineData(6, 2, 3)]
        [InlineData(7, 7)]
        [InlineData(8, 2, 2, 2)]
        [InlineData(9, 3, 3)]
        public void Factors_Number_Expected(int number, params int[] expected)
        {
            var acutal = Primfactors.Factors(number);

            Assert.Equal(expected, acutal);
        }

        [Fact(DisplayName = "Factors Acceptance test")]
        public void Factors_AcceptanceTest()
        {
            var expected = new List<int> { 2, 3, 7, 11, 13, 17, 19, 23, 29 };

            var actual = Primfactors.Factors(2 * 3 * 7 * 11 * 13 * 17 * 19 * 23 * 29);

            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Factors Performance should be good")]
        public void Factors_PerformanceTest()
        {
            var timer = new Stopwatch();
            timer.Start();
            Primfactors.Factors(int.MaxValue);
            timer.Stop();

            Assert.True(timer.ElapsedMilliseconds < 1000, $"Slow performance, running for {timer.ElapsedMilliseconds / 1000 } sec.");
        }
    }
}
