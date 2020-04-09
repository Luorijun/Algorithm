using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_151
{
    public class Solution
    {
        public string ReverseWords(string s) => string.Join(' ', s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}