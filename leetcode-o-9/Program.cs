using System;

namespace leetcode_o_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new CQueue();
            queue.AppendTail(3);
            Console.WriteLine(queue.DeleteHead());
            Console.WriteLine(queue.DeleteHead());
        }
    }
}