using System.IO;

public class Solution
{
    static void Main()
    {
        var input = File.ReadAllText("./input.txt");
        Console.WriteLine($"Day1 part 1: {Day1.SolvePart1(input)}");
        Console.WriteLine($"Day1 part 2: {Day1.SolvePart2(input)}");
    }
}