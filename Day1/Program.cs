using System.IO;

public class Program
{
    static void Main()
    {
        var input = File.ReadAllText("./input.txt");
        Console.WriteLine($"Day1 part 1: {Day1.SolvePart1(input)}");
    }
}