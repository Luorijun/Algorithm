using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_m_2_1
{
    public class Solution
    {
        public ListNode RemoveDuplicateNodes(ListNode head)
        {
            if (head == null) return null;

            var record = new HashSet<int>(new[] {head.val});

            var node = head.next;
            var root = new ListNode(head.val);
            var curr = root;

            while (node != null)
            {
                if (!record.Contains(node.val))
                {
                    record.Add(node.val);
                    curr.next = new ListNode(node.val);
                    curr = curr.next;
                }
                node = node.next;
            }
            return root;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x) => val = x;

        public override string ToString() => $"{val} -> {next}";
    }
}