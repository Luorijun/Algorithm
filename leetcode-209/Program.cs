using System;

namespace leetcode_209
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MinSubArrayLen(7, new int[] { }));
            Console.WriteLine(solution.MinSubArrayLen(7, new[] {2, 3, 1, 2, 4, 3}));
            Console.WriteLine(solution.MinSubArrayLen(80, new[] {10, 5, 13, 4, 8, 4, 5, 11, 14, 9, 16, 10, 20, 8}));
        }
    }
}