using System;

namespace leetcode_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(string.Join(",", solution.PlusOne(new[] {0})));
            Console.WriteLine(string.Join(",", solution.PlusOne(new[] {1,2,3})));
            Console.WriteLine(string.Join(",", solution.PlusOne(new[] {1,2,9})));
            Console.WriteLine(string.Join(",", solution.PlusOne(new[] {9,9,9})));
        }
    }
}