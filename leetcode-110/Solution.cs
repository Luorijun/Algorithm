using System;
using System.Collections.Generic;

namespace leetcode_110
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return CheckTreeNode(root) != -1;
        }

        private static int CheckTreeNode(TreeNode node)
        {
            if (node == null) return 0;

            var left = CheckTreeNode(node.left);
            var right = CheckTreeNode(node.right);
            if (left == -1 || right == -1 || Math.Abs(left - right) > 1) return -1;
            return Math.Max(left, right) + 1;
        }
    }
}