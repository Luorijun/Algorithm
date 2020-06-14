using System;
using System.Collections.Generic;

namespace leetcode_887
{
    public class Solution
    {
        private Dictionary<int, int> dictionary = new Dictionary<int, int>();

        public int SuperEggDrop(int K, int N)
        {
            if (K == 1 || N < 2) return N;
            if (dictionary.TryGetValue(N*100+K, out var output)) return output;

            int lo = 1, hi = N;
            while (lo + 1 < hi)
            {
                var x = (lo + hi) / 2;
                var t1 = SuperEggDrop(K - 1, x - 1);
                var t2 = SuperEggDrop(K, N - x);

                if (t1 < t2)
                    lo = x;
                else if (t1 > t2)
                    hi = x;
                else
                    lo = hi = x;
            }

            var result = 1 + Math.Min(
                Math.Max(SuperEggDrop(K - 1, lo - 1), SuperEggDrop(K, N - lo)),
                Math.Max(SuperEggDrop(K - 1, hi - 1), SuperEggDrop(K, N - hi))
            );
            dictionary.Add(N * 100 + K, result);
            return result;
        }
    }
}