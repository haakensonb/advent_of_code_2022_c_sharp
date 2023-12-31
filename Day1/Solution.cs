﻿namespace AdventOfCode.Year2022.Day1
{
    public class Solution
    {
        private static IEnumerable<IEnumerable<int>> ParseInput(string input)
        {
            string[] lineGroups = input.Split("\n\n");
            var calories = lineGroups.Select(x => x
                .Split("\n")
                .Select(x => Int32.Parse(x))
                );
            return calories;
        }

        private static IEnumerable<int> SumCalories(IEnumerable<IEnumerable<int>> calories)
        {
            return calories.Select(x => x.Sum());
        }

        public static int SolvePart1(string input)
        {
            var calories = Solution.ParseInput(input);
            var caloriesSums = Solution.SumCalories(calories);
            return caloriesSums.Max();
        }

        public static int SolvePart2(string input)
        {
            var calories = Solution.ParseInput(input);
            var caloriesSums = Solution.SumCalories(calories);
            return caloriesSums.OrderDescending().Take(3).Sum();
        }
    }
}