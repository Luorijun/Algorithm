using System;

namespace leetcode_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MaxScoreSightseeingPair(new []{8,1,5,2,6}));
            Console.WriteLine(solution.MaxScoreSightseeingPair(new []{8,1,5,2,6,7,7}));
        }
    }
}