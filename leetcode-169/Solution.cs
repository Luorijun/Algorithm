namespace leetcode_169
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var count = 0;
            var num = 0;
            foreach (var v in nums)
            {
                if (count == 0) num = v;
                if (num == v) count++;
                else count--;
            }

            return num;
        }
    }
}