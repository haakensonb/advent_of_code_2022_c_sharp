using System.IO;
using AdventOfCode.Year2022.Day1;

public class Program
{
    static void Main()
    {
        var input = File.ReadAllText("./input.txt");
        Console.WriteLine($"Day1 part 1: {Solution.SolvePart1(input)}");
        Console.WriteLine($"Day1 part 2: {Solution.SolvePart2(input)}");
    }
}