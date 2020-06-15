namespace leetcode_14
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            var r = "";
            var i = 0;
            while (true)
            {
                var c = ' ';
                foreach (var s in strs)
                    if (i == s.Length) return r;
                    else if (c == ' ') c = s[i];
                    else if (c != s[i]) return r;
                r += c;
                i++;
            }
        }
    }
}