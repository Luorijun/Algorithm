using System;

namespace leetcode_m_16_18
{
    public class Solution
    {
        public bool PatternMatching(string pattern, string value)
        {
            if (pattern == "" && value == "") return true;
            if (pattern.Length == 1) return true;
            if ((pattern == "ab" || pattern == "ba") && value != "") return true;

            var ca = 0;
            var cb = 0;
            foreach (var c in pattern)
                if (c == 'a') ca++;
                else cb++;


            for (var i = 0; i <= value.Length; i++)
            {
                var la = i;
                var lb = (value.Length - la * ca) / (float) cb;

                if (lb < 0 || Math.Abs(lb % 1) > 0) continue;

                var sa = "";
                var sb = "";

                var p = 0;
                foreach (var c in pattern)
                    switch (c)
                    {
                        case 'a' when la != 0:
                            if (sa == "") sa = value.Substring(p, la);
                            else if (sa != value.Substring(p, la)) break;
                            p += la;
                            break;

                        case 'b' when (int) lb != 0:
                            if (sb == "") sb = value.Substring(p, (int) lb);
                            else if (sb != value.Substring(p, (int) lb)) break;
                            p += (int) lb;
                            break;
                    }

                if (p == value.Length && sa != sb) return true;
            }

            return false;
        }
    }
}