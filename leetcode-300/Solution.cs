using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_300
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;

            var list = new List<int>(new[] {nums[0]});
            for (var i = 1; i < nums.Length; i++)
                if (nums[i] < list.First())
                    list[0] = nums[i];
                else if (list.Last() < nums[i])
                    list.Add(nums[i]);
                else
                {
                    var index = ~list.BinarySearch(nums[i]);
                    if (index > 0) list[index] = nums[i];
                }
            return list.Count;
        }
    }
}