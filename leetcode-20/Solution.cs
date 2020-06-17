using System.Collections.Generic;

namespace leetcode_20
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var t in s)
                switch (t)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(t);
                        break;
                    case '}':
                        if (!stack.TryPop(out var l) || l != '{') return false;
                        break;
                    case ']':
                        if (!stack.TryPop(out var m) || m != '[') return false;
                        break;
                    case ')':
                        if (!stack.TryPop(out var o) || o != '(') return false;
                        break;
                }

            return stack.Count == 0;
        }
    }
}