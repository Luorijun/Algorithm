using System;

namespace leetcode_1160
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.CountCharacters(new []{"cat","bt","hat","tree"}, "atach"));
            Console.WriteLine(solution.CountCharacters(new []{"hello","world","leetcode"}, "welldonehoneyr"));
        }
    }
}