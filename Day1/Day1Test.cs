using System.Reflection;
using Xunit;

public class Day1Test
{
    string input = @"1000
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
        Assert.Equal(24000, Day1.SolvePart1(this.input));
    }

    [Fact]
    public void Part2Test()
    {
        Assert.Equal(45000, Day1.SolvePart2(this.input));
    }
}