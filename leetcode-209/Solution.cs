using System;
using System.Collections.Generic;

namespace leetcode_209
{
    public class Solution
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            var queue = new Queue<int>();
            var min = int.MaxValue;
            var sum = 0;
            foreach (var t in nums)
            {
                sum += t;
                queue.Enqueue(t);

                while (sum >= s)
                {
                    min = Math.Min(min, queue.Count);
                    sum -= queue.Dequeue();
                }
            }
            return min == int.MaxValue ? 0 : min;
        }
    }
}