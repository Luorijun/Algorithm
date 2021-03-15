using System;

namespace leetcode_3
{
    class Program
    {
        private static readonly Solution Solution = new();

        static void Main(string[] args)
        {
            Test("abcabcbb");
            Test("bbbbb");
            Test("pwwkew");
            Test("");
            Test("abba");
        }

        static void Test(string s)
        {
            var result = Solution.LengthOfLongestSubstring(s);
            Console.WriteLine(result);
        }
    }
}