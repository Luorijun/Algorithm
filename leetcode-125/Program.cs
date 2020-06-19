using System;

namespace leetcode_125
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(""));
            Console.WriteLine(solution.IsPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(solution.IsPalindrome("race a car"));
        }
    }
}