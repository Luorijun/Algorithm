namespace leetcode_206
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            var previous = head;
            var current = head.next;
            head.next = null;
            while (current.next != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            current.next = previous;
            return current;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}