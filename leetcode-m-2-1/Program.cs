using System;

namespace leetcode_m_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var a = new ListNode(123);
            var b = new ListNode(123);
            var c = new ListNode(456);
            var d = new ListNode(456);
            var e = new ListNode(789);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;

            Console.WriteLine(solution.RemoveDuplicateNodes(a));

            Console.WriteLine(solution.RemoveDuplicateNodes(null));
        }
    }
}