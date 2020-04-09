using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_409
{
    public class Solution
    {
        public int LongestPalindrome(string s)
        {
            if (s.Length < 2) return s.Length;

            var arr = new int[128];
            foreach (var i in s) arr[i - 'A']++;
            var t = arr.Sum(j => j & 1);

            return t == 0 ? s.Length - t : s.Length - t + 1;
        }
    }
}