using System.Collections.Generic;

namespace leetcode_733
{
    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var oldColor = image[sr][sc];
            if (newColor == oldColor) return image;

            var stack = new Stack<int[]>();
            stack.Push(new[] {sr, sc});
            while (stack.TryPop(out var pixel))
            {
                var x = pixel[0];
                var y = pixel[1];
                image[x][y] = newColor;
                if (x > 0 && image[x - 1][y] == oldColor)
                    stack.Push(new[] {x - 1, y});
                if (y > 0 && image[x][y - 1] == oldColor)
                    stack.Push(new[] {x, y - 1});
                if (x < image.Length - 1 && image[x + 1][y] == oldColor)
                    stack.Push(new[] {x + 1, y});
                if (y < image[0].Length - 1 && image[x][y + 1] == oldColor)
                    stack.Push(new[] {x, y + 1});
            }

            return image;
        }
    }
}