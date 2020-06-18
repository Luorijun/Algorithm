using System.Collections.Generic;
using System.Linq;

namespace leetcode_1028
{
    public class Solution
    {
        public TreeNode RecoverFromPreorder(string S)
        {
            var stack = new Stack<TreeNode>();

            var last = 0;
            var deep = 0;
            var num = "";

            for (var i = 0; i < S.Length; i++)
                if (S[i] == '-') deep++;
                else
                {
                    num += S[i];
                    if (i + 1 != S.Length && S[i + 1] != '-') continue;
                    var node = new TreeNode(int.Parse(num));
                    if (deep != 0)
                        if (last < deep) stack.Peek().left = node;
                        else
                        {
                            while (last-- >= deep)
                                stack.Pop();
                            stack.Peek().right = node;
                        }

                    last = deep;
                    deep = 0;
                    num = "";
                    stack.Push(node);
                }

            return stack.ToList().Last();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) => val = x;
    }
}