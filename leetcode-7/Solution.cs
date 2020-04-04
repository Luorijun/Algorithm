﻿namespace leetcode_7
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long n = 0;
            while (x != 0)
            {
                n = n * 10 + x % 10;
                x /= 10;
            }

            return (int) n == n ? (int) n : 0;
        }
    }
}