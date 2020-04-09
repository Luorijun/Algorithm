using System;

namespace leetcode_121
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MaxProfit(new[] {0}) == 0);
            Console.WriteLine(solution.MaxProfit(new[] {1}) == 0);
            Console.WriteLine(solution.MaxProfit(new[] {1, 2, 3, 4, 3, 2, 1}) == 3);
            Console.WriteLine(solution.MaxProfit(new[] {4, 3, 2, 1, 2, 3, 4}) == 3);
            Console.WriteLine(solution.MaxProfit(new[] {2, 4, 6, 8, 3, 2, 1}) == 6);
            Console.WriteLine(solution.MaxProfit(new[] {4, 3, 2, 1, 4, 6, 8}) == 7);
            Console.WriteLine(solution.MaxProfit(new[] {1, 2, 3, 4, 5, 6, 7}) == 6);
            Console.WriteLine(solution.MaxProfit(new[] {7, 6, 5, 4, 3, 2, 1}) == 0);
            Console.WriteLine(solution.MaxProfit(new[] {7, 1, 5, 3, 6, 4}) == 5);
        }
    }
}