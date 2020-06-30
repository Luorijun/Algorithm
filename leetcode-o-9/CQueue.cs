using System.Collections.Generic;

namespace leetcode_o_9
{
    public class CQueue
    {
        private Stack<int> stackIn;
        private Stack<int> stackOut;

        public CQueue()
        {
            stackIn = new Stack<int>();
            stackOut = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            stackIn.Push(value);
        }

        public int DeleteHead()
        {
            if (stackOut.TryPop(out var result)) return result;
            while (stackIn.TryPop(out result)) stackOut.Push(result);
            if (stackOut.TryPop(out result)) return result;
            return -1;
        }
    }
}