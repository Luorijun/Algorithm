namespace leetcode_42
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            var count = 0;
            var temp = 0;
            var start = false;
            var left = 0;

            for (var i = 0; i < height.Length; i++)
            {
                if (start)
                {
                    if (height[left] > height[i])
                        temp += height[left] - height[i];
                    else
                    {
                        left = i;
                        if (temp == 0) continue;
                        count += temp;
                        temp = 0;
                    }
                }
                else
                {
                    if (height[i] == 0) continue;
                    left = i;
                    start = true;
                }
            }

            temp = 0;
            start = false;
            var record = left;

            for (var i = height.Length - 1; i >= record; i--)
            {
                if (start)
                {
                    if (height[left] > height[i])
                        temp += height[left] - height[i];
                    else
                    {
                        left = i;
                        if (temp == 0) continue;
                        count += temp;
                        temp = 0;
                    }
                }
                else
                {
                    if (height[i] == 0) continue;
                    left = i;
                    start = true;
                }
            }

            return count;
        }
    }
}