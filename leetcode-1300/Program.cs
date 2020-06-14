using System;
using System.Collections.Generic;

namespace leetcode_1300
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.FindBestValue(new[] {1, 2, 2}, 10));
            Console.WriteLine(solution.FindBestValue(new[] {4, 9, 3}, 10));
            Console.WriteLine(solution.FindBestValue(new[] {2, 3, 5}, 10));
        }
    }
}