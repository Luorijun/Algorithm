using System;

namespace leetcode_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.IsMatch("bbcc", "b*d*.c"));
        }
    }
}