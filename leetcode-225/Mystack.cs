using System.Collections.Generic;

namespace leetcode_225
{
    public class MyStack
    {
        private bool select;
        private Queue<int> queue1;
        private Queue<int> queue2;

        public MyStack()
        {
            select = true;
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }

        public void Push(int x)
        {
            if (select)
                queue1.Enqueue(x);
            else
                queue2.Enqueue(x);
        }

        public int Pop()
        {
            var last = 0;
            if (@select)
                while (queue1.TryDequeue(out var result))
                    if (queue1.TryPeek(out var p))
                        queue2.Enqueue(result);
                    else last = result;
            else
                while (queue2.TryDequeue(out var result))
                    if (queue2.TryPeek(out var p))
                        queue1.Enqueue(result);
                    else last = result;
            @select = !@select;
            return last;
        }

        public int Top()
        {
            var last = 0;
            if (select)
                foreach (var i in queue1)
                    last = i;
            else
                foreach (var i in queue2)
                    last = i;

            return last;
        }

        public bool Empty()
        {
            if (@select)
                return queue1.Count == 0;
            return queue2.Count == 0;
        }
    }
}