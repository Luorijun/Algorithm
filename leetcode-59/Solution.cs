using System;

namespace leetcode_59
{
    public class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            var matrix = new int[n][];
            for (var m = 0; m < matrix.Length; m++)
            {
                matrix[m] = new int[n];
            }

            var top = 1;
            var left = 0;
            var right = n - 1;
            var bottom = n - 1;

            var i = 0;
            var j = -1;
            var d = 0;
            var c = 1;
            while (top <= bottom || left <= right)
            {
                switch (d)
                {
                    case 0:
                        if (++j == right)
                        {
                            d = 1;
                            right--;
                        }

                        break;
                    case 1:
                        if (++i == bottom)
                        {
                            d = 2;
                            bottom--;
                        }

                        break;
                    case 2:
                        if (--j == left)
                        {
                            d = 3;
                            left++;
                        }

                        break;
                    case 3:
                        if (--i == top)
                        {
                            d = 0;
                            top++;
                        }

                        break;
                }

                matrix[i][j] = c++;
            }

            return matrix;
        }
    }
}