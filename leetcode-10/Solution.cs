using System.Collections.Generic;

namespace leetcode_10
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            var m = s.Length;
            var n = p.Length;

            var f = new bool[m + 1, n + 1];
            f[0, 0] = true;

            for (var i = 0; i <= m; ++i)
            for (var j = 1; j <= n; ++j)
            {
                if (p[j - 1] == '*')
                {
                    f[i, j] = f[i, j - 2];
                    if (Matches(s, p, i, j - 1))
                    {
                        f[i, j] = f[i, j] || f[i - 1, j];
                    }
                }
                else
                {
                    if (Matches(s, p, i, j))
                    {
                        f[i, j] = f[i - 1, j - 1];
                    }
                }
            }

            return f[m,n];
        }

        private static bool Matches(string s, string p, int i, int j)
        {
            if (i == 0) return false;
            if (p[j-1] == '.') return true;
            return s[i - 1] == p[j - 1];
        }
    }
}