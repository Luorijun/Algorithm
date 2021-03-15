using System;
using System.Collections;
using System.Collections.Generic;

namespace leetcode_54
{
    class Program
    {
        private static readonly Solution Solution = new();

        static void Main(string[] args)
        {
            Test(Array.Empty<int[]>());

            Test(new[]
            {
                new[] {1}
            });

            Test(new[]
            {
                new[] {1, 2, 3, 4, 5}
            });

            Test(new[]
            {
                new[] {1, 2},
                new[] {3, 4}
            });

            Test(new[]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            });

            Test(new[]
            {
                new[] {1, 2, 3, 4},
                new[] {5, 6, 7, 8},
                new[] {9, 10, 11, 12}
            });

            Test(new[]
            {
                new[] {1},
                new[] {2},
                new[] {3},
                new[] {4},
                new[] {5},
            });
        }

        private static void Test(int[][] input)
        {
            var result = Solution.SpiralOrder(input);
            foreach (var i in result)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
        }
    }
}