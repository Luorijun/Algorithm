using System;

namespace leetcode_42
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.Trap(new[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});
            Console.WriteLine(result);
        }
    }
}