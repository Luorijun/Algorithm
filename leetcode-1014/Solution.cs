using System;

namespace leetcode_1014
{
    public class Solution
    {
        public int MaxScoreSightseeingPair(int[] A)
        {
            var last = A[0];
            var max = 0;
            for (var i = 1; i < A.Length; i++)
            {
                last = Math.Max(last - 1, A[i - 1] - 1);
                max = Math.Max(max, A[i] + last);
            }
            return max;
        }
    }
}