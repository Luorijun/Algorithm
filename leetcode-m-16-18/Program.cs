using System;

namespace leetcode_m_16_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.PatternMatching("", "")); // t
            Console.WriteLine(solution.PatternMatching("a", "")); // t
            Console.WriteLine(solution.PatternMatching("a", "zqvamqvuuvvazv")); // t
            Console.WriteLine(solution.PatternMatching("ab", "")); // f
            Console.WriteLine(solution.PatternMatching("ab", "asdqwe")); // t
            Console.WriteLine(solution.PatternMatching("abba", "dogcatcatdog")); // t
            Console.WriteLine(solution.PatternMatching("abba", "dogcatcatfish")); // f
            Console.WriteLine(solution.PatternMatching("aaaa", "dogcatcatdog")); // f
            Console.WriteLine(solution.PatternMatching("abba", "dogdogdogdog")); // t
            Console.WriteLine(solution.PatternMatching(
                "bbbbbbbbbbbbbbabbbbb",
                "ppppppppppppppjsftcleifftfthiehjiheyqkhjfkyfckbtwbelfcgihlrfkrwireflijkjyppppg")); // t
        }
    }
}