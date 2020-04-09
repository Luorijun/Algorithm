using System;

namespace leetcode_409
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.LongestPalindrome(""));
            Console.WriteLine(solution.LongestPalindrome("bb"));
            Console.WriteLine(solution.LongestPalindrome("abc"));
            Console.WriteLine(solution.LongestPalindrome("abccccdd"));
            Console.WriteLine(solution.LongestPalindrome("abcccddd"));
        }
    }
}