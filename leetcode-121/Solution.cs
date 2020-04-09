using System;

namespace leetcode_121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0;

            var gap = 0;
            var min = prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                gap = Math.Max(gap, prices[i] - min);
                if (min > prices[i]) min = prices[i];
            }

            return gap;
        }
    }
}