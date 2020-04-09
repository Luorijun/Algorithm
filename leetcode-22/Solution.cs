using System.Collections.Generic;

namespace leetcode_22
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var list = new List<string>();
            DFS(n, 0, 0, "", list);
            return list;
        }

        public void DFS(int n, int l, int r, string result, List<string> list)
        {
            if (l == n && n == r) list.Add(result);
            else
            {
                if (n > l) DFS(n, l + 1, r, result + "(", list);
                if (l > r) DFS(n, l, r + 1, result + ")", list);
            }
        }
    }
}