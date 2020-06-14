using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace leetcode_1300
{
    public class Solution
    {
        public int FindBestValue(int[] arr, int target)
        {
            Array.Sort(arr);

            var sum = 0;
            var result = 0;
            var prev = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var curr = sum + result * (arr.Length - i);
                if (curr == target) break;
                if (curr - target >= target - prev)
                {
                    result--;
                    break;
                }

                result++;

                while (i < arr.Length && arr[i] == result)
                {
                    sum += arr[i];
                    i++;
                }

                if (i == arr.Length) break;

                i--;
                prev = curr;
            }

            return result;
        }
    }
}