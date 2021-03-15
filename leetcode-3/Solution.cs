using System;
using System.Collections.Generic;

namespace leetcode_3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var start = 0;
            var max = 0;

            var cs = s.ToCharArray();
            var record = new Dictionary<char, int>();
            for (var end = 0; end < cs.Length; end++)
            {
                var c = cs[end];
                if (record.ContainsKey(c) && record[c] >= start)
                    start = record[c] + 1;
                record[c] = end;
                max = Math.Max(max, end - start + 1);
            }

            return max;
        }
    }
}