using System;

namespace leetcode_300
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.LengthOfLIS(Array.Empty<int>()));
            Console.WriteLine(solution.LengthOfLIS(new[] {2}));
            Console.WriteLine(solution.LengthOfLIS(new[] {2, 2, 2, 2, 2, 2, 2, 2}));
            Console.WriteLine(solution.LengthOfLIS(new[] {2, 5, 3, 4, 7, 4, 5, 6}));
            Console.WriteLine(solution.LengthOfLIS(new[] {10, 9, 2, 5, 3, 7, 101, 18}));
            Console.WriteLine(solution.LengthOfLIS(new[] {7, 8, 9, 70, 2, 3, 4, 5, 6, 7}));
        }
    }
}