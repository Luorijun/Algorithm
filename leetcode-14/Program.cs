using System;

namespace leetcode_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.LongestCommonPrefix(new string[] { })); // 空字符
            Console.WriteLine(solution.LongestCommonPrefix(new[] {"qwe", "asd", ""})); // 空字符
            Console.WriteLine(solution.LongestCommonPrefix(new[] {"qwe", "qweasd", ""})); // 空字符
            Console.WriteLine(solution.LongestCommonPrefix(new[] {"dog", "racecar", "car"})); // 无匹配
            Console.WriteLine(solution.LongestCommonPrefix(new[] {"flower", "flow", "flight"})); // 有匹配
            Console.WriteLine(solution.LongestCommonPrefix(new[] {"text", "texture", "tex"})); // 有匹配
            Console.WriteLine(solution.LongestCommonPrefix(new[] {"hahaha", "hahaha", "hahaha"})); // 全匹配
        }
    }
}