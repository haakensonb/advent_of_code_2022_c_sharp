using Xunit;
using AdventOfCode.Year2022.Day1;

namespace AdventOfCode.Year2022.Day1.Tests
{
    public class SolutionTest
    {
        const string input = @"1000
            2000
            3000

            4000

            5000
            6000

            7000
            8000
            9000

            10000";

        [Fact]
        public void Part1Test()
        {
            Assert.Equal(24000, Solution.SolvePart1(input));
        }

        [Fact]
        public void Part2Test()
        {
            Assert.Equal(45000, Solution.SolvePart2(input));
        }
    }
}