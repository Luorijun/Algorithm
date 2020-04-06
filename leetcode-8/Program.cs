using System;

namespace leetcode_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MyAtoi(""));
            Console.WriteLine(solution.MyAtoi("-"));
            Console.WriteLine(solution.MyAtoi("  "));
            Console.WriteLine(solution.MyAtoi(" - 123"));
            Console.WriteLine(solution.MyAtoi(" -321"));
            Console.WriteLine(solution.MyAtoi(" +321"));
            Console.WriteLine(solution.MyAtoi("ewr"));
            Console.WriteLine(solution.MyAtoi("afe -123"));
            Console.WriteLine(solution.MyAtoi("123-"));
            Console.WriteLine(solution.MyAtoi("42 34"));
            Console.WriteLine(solution.MyAtoi(".1"));
            Console.WriteLine(solution.MyAtoi("423452253534"));
            Console.WriteLine(solution.MyAtoi("-423452253534"));
            Console.WriteLine(solution.MyAtoi("20000000000000000000"));
            Console.WriteLine(solution.MyAtoi("+-2"));
        }
    }
}