using System;
using System.Linq;

namespace leetcode_8
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            str = str.Trim();
            var record = "";

            for (var i = 0; i < str.Length; i++)
                if (i == 0 && (str[i] == '-' || str[i] == '+')) record += str[i];
                else if ('0' <= str[i] && str[i] <= '9') record += str[i];
                else break;

            if (record == "" || record == "-" || record == "+") return 0;
            if (int.TryParse(record, out var result)) return result;
            return record[0] == '-' ? int.MinValue : int.MaxValue;
        }
    }
}