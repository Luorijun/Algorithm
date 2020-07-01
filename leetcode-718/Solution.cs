using System;

namespace leetcode_718
{
    public class Solution
    {
        public int FindLength(int[] A, int[] B)
        {
            var max = 0;
            for (var i = -B.Length + 1; i < A.Length; i++)
            {
                var current = 0;
                for (var j = 0; j < B.Length; j++)
                    if (i + j >= A.Length) break;
                    else if (i + j < 0) continue;
                    else if (A[i + j] == B[j]) current++;
                    else if (current != 0)
                    {
                        max = Math.Max(max, current);
                        current = 0;
                    }
                max = Math.Max(max, current);
            }

            return max;
        }
    }
}