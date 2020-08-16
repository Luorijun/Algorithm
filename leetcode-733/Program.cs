using System;

namespace leetcode_733
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var image = new[]
            {
                new[] {1, 1, 1},
                new[] {1, 1, 0},
                new[] {1, 0, 1}
            };
            foreach (var col in solution.FloodFill(image, 1, 1, 2))
            {
                foreach (var i in col)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            image = new[]
            {
                new[] {0, 0, 0},
                new[] {1, 0, 0}
            };
            foreach (var col in solution.FloodFill(image, 1, 0, 2))
            {
                foreach (var i in col)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}