using System;

namespace leetcode_72
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            var m = word1.Length + 1;
            var n = word2.Length + 1;
            var dp = new int[m, n];

            for (var i = 0; i < m; i++) dp[i, 0] = i;
            for (var j = 0; j < n; j++) dp[0, j] = j;

            for (var i = 1; i < m; i++)
            for (var j = 1; j < n; j++)
                dp[i, j] =
                    word1[i - 1] == word2[j - 1]
                        ? dp[i - 1, j - 1]
                        : Min(dp[i - 1, j - 1] + 1,
                              dp[i - 1, j] + 1,
                              dp[i, j - 1] + 1);

            return dp[m - 1, n - 1];
        }

        private static int Min(int a, int b, int c) => a > b ? b > c ? c : b : a > c ? c : a;
    }
}