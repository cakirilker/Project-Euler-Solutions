using System;
using Xunit;
using ProjectEuler;

namespace ProjectEuler.Tests
{
    public class ProblemTests
    {
        [Fact]
        public void Promlem4_ShouldReturn_906609()
        {
            Assert.Equal(Problem4.LargestThreeDigitPalindrome(),906609);
        }

        [Fact] 
        public void Problem8_ShouldReturn_23514624000()
        {
            Assert.Equal(Problem8.GetResult(), 23514624000);
        }
    }
}