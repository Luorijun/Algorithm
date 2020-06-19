using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace leetcode_125
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = new string(s.ToLower().Where(c => '0' <= c && c <= '9' || 'a' <= c && c <= 'z').ToArray());
            return s == new string(s.Reverse().ToArray());
        }
    }
}