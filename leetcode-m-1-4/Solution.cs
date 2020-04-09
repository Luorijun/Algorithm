using System;

namespace leetcode_m_1_4
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            var s = matrix.Length; //size
            var l = s - 1; //last
            for (var r = 0; r <= s / 2; r++)
            for (var c = r; c < l - r; c++)
            {
                var tmp = matrix[r][c];
                matrix[r][c] = matrix[l - c][r];
                matrix[l - c][r] = matrix[l - r][l - c];
                matrix[l - r][l - c] = matrix[c][l - r];
                matrix[c][l - r] = tmp;
            }
        }
    }
}