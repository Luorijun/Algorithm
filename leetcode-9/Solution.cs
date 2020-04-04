using System;

namespace leetcode_9
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var m = x;
            if (x < 0) return false;
            if (x < 10) return true;
            if (x % 10 == 0) return false;

            long n = 0;
            while (m != 0)
            {
                n = n * 10 + m % 10;
                m /= 10;
            }

            return x == n;
        }
    }
}