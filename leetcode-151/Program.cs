using System;

namespace leetcode_151
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.ReverseWords(""));
            Console.WriteLine(solution.ReverseWords("    "));
            Console.WriteLine(solution.ReverseWords("wqerwesdfa"));
            Console.WriteLine(solution.ReverseWords("   a good   example    "));
        }
    }
}