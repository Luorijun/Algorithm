using System;
using System.Linq;

namespace leetcode_test
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            var sum = nums.Sum();
            var left = 0;
            for (var i = 0; i < nums.Length; i++)
                if (left == (sum -= nums[i])) return i;
                else left += nums[i];
            return -1;
        }

        public int DominantIndex(int[] nums)
        {
            if (nums.Length == 1) return 0;

            var second = -1;
            var first = 0;
            var index = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (first < nums[i])
                {
                    second = first;
                    first = nums[i];
                    index = i;
                }
                else if (second < nums[i])
                    second = nums[i];
            }

            if (first >= second * 2) return index;
            return -1;
        }

        public int[] PlusOne(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] = digits[i] != 9 ? digits[i] + 1 : 0;
                if (digits[i] != 0) return digits;
            }

            var list = digits.ToList();
            list.Insert(0, 1);
            return list.ToArray();
        }
    }
}