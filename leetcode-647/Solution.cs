namespace leetcode_647
{
    public class Solution
    {
        public int CountSubstrings(string s)
        {
            var count = 0;
            for (var i = 0; i < s.Length * 2 - 1; i++)
            {
                var l = i / 2;
                var r = i / 2 + i % 2;
                while (l >= 0 && r < s.Length && s[l--] == s[r++]) count++;
            }
            return count;
        }
    }
}