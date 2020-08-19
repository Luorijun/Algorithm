using System;

namespace leetcode_647
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.CountSubstrings("") == 0);
            Console.WriteLine(solution.CountSubstrings("a") == 1);
            Console.WriteLine(solution.CountSubstrings("abc") == 3);
            Console.WriteLine(solution.CountSubstrings("aaa") == 6);
            Console.WriteLine(solution.CountSubstrings("abba") == 6);
            Console.WriteLine(solution.CountSubstrings("aaaaa") == 15);
        }
    }
}