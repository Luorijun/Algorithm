using System.Collections.Generic;
using System.Linq;

namespace leetcode_1160
{
    public class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            var array = chars.ToCharArray();
            var length = 0;
            foreach (var word in words)
            {
                var match = true;
                var s = new List<char>(array);
                foreach (var t in word)
                    if (s.Contains(t)) s.Remove(t);
                    else
                    {
                        match = false;
                        break;
                    }
                if (match) length += word.Length;
            }
            return length;
        }
    }
}