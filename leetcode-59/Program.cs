using System;

namespace leetcode_59
{
    class Program
    {
        private static readonly Solution Solution = new();

        static void Main(string[] args)
        {
            Test(4);
            Test(5);
            Test(6);
        }

        static void Test(int n)
        {
            var result = Solution.GenerateMatrix(n);
            foreach (var row in result)
            {
                foreach (var i in row)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("========================");
        }
    }
}