using System;

namespace leetcode_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.GenerateParenthesis(3);
            foreach (var r in result) Console.WriteLine(r);
        }
    }
}