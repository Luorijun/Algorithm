using System;
using System.Collections.Generic;

namespace leetcode_54
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return new List<int>();
            }

            var top = 1;
            var left = 0;
            var right = matrix[0].Length - 1;
            var bottom = matrix.Length - 1;
            var list = new List<int>();

            var i = -1;
            var j = 0;
            var d = 0;

            while (left <= right && (d == 0 || d == 2) || top <= bottom && (d == 1 || d == 3))
            {
                switch (d)
                {
                    case 0:
                        if (++i == right)
                        {
                            d = 1;
                            right--;
                        }

                        break;
                    case 1:
                        if (++j == bottom)
                        {
                            d = 2;
                            bottom--;
                        }

                        break;
                    case 2:
                        if (--i == left)
                        {
                            d = 3;
                            left++;
                        }

                        break;
                    case 3:
                        if (--j == top)
                        {
                            d = 0;
                            top++;
                        }

                        break;
                }

                list.Add(matrix[j][i]);
            }

            return list;
        }
    }
}