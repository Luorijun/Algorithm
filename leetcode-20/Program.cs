using System;

namespace leetcode_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.IsValid(""));
            Console.WriteLine(solution.IsValid("()"));
            Console.WriteLine(solution.IsValid("()[]{}"));
            Console.WriteLine(solution.IsValid("(]"));
            Console.WriteLine(solution.IsValid("([)]"));
            Console.WriteLine(solution.IsValid("{[]}"));
        }
    }
}