namespace leetcode_m_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var matrix = new[]
            {
                new[] {1, 2, 3, 4, 5, 6},
                new[] {4, 5, 6, 7, 8, 9},
                new[] {7, 8, 9, 0, 1, 0},
                new[] {7, 8, 9, 4, 3, 0},
                new[] {7, 8, 9, 2, 0, 0},
                new[] {7, 8, 9, 0, 5, 6}
            };
            solution.Rotate(matrix);
        }
    }
}