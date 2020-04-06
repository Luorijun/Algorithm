using System;

namespace leetcode_72
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MinDistance("a", "a"));
            Console.WriteLine(solution.MinDistance(" a", "a"));
            Console.WriteLine(solution.MinDistance(" a", "a "));
            Console.WriteLine(solution.MinDistance("abab", "b"));
            Console.WriteLine(solution.MinDistance("horse", "ros"));
            Console.WriteLine(solution.MinDistance("intention", "execution"));
            Console.WriteLine(solution.MinDistance(
                "pneumonoultramicroscopicsilicovolcanoconiosis",
                "ultramicroscopically"));
        }
    }
}