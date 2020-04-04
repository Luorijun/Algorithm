namespace leetcode_13
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var n = 0;
            for (var i = 0; i < s.Length; i++)
            {
                n += s[i] switch
                {
                    'D' => 500,
                    'C' => (i < s.Length - 1 && (s[i + 1] == 'M' || s[i + 1] == 'D') ? -100 : 100),
                    'L' => 50,
                    'X' => (i < s.Length - 1 && (s[i + 1] == 'C' || s[i + 1] == 'L') ? -10 : 10),
                    'V' => 5,
                    'I' => (i < s.Length - 1 && (s[i + 1] == 'X' || s[i + 1] == 'V') ? -1 : 1),
                    _ => 1000
                };
            }
            return n;
        }
    }
}