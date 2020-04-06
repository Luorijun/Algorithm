using System.Collections.Generic;

namespace leetcode_460
{
    public class LFUCache
    {
        private int length;
        private readonly int capacity;
        private readonly Dictionary<int, Data> cache;
        private readonly LinkedList<Group> freq;

        public LFUCache(int capacity)
        {
            length = 0;
            this.capacity = capacity;
            cache = new Dictionary<int, Data>(capacity);
            freq = new LinkedList<Group>();
        }

        public void Put(int key, int value)
        {
            // 排除非法操作
            if (capacity == 0) return;

            // 获取缓存
            // 如果缓存存在（更新缓存）
            if (cache.TryGetValue(key, out var data))
            {
                // 更新频率表，删除旧纪录，增加新记录
                var current = UpdateFrequency(key, data.freq);

                // 更新缓存值
                cache[key] = new Data
                {
                    value = value,
                    freq = current
                };
            }

            // 如果缓存不存在（新增缓存）
            else
            {
                // 如果缓存已满（删除缓存）
                if (cache.Count >= capacity)
                {
                    // 更新频率表，删除旧记录
                    var tag = freq.First.Value.record.First.Value;
                    freq.First.Value.record.RemoveFirst();

                    // 删除旧缓存值
                    cache.Remove(tag);
                }

                // 更新频率表，增加新记录
                if (freq.First == null)
                {
                    freq.AddFirst(new Group
                    {
                        freq = 0,
                        record = new LinkedList<int>()
                    });
                }
                else if (freq.First.Value.freq != 0)
                    freq.AddFirst(new Group
                    {
                        freq = 0,
                        record = new LinkedList<int>()
                    });

                var current = freq.First.Value.record.AddLast(key);

                // 增加新缓存值
                cache[key] = new Data
                {
                    value = value,
                    freq = freq.First
                };
            }
        }

        public int Get(int key)
        {
            // 获取缓存
            // 如果缓存不存在，返回 -1
            if (!cache.TryGetValue(key, out var data)) return -1;

            // 如果缓存存在
            // 更新频率表，删除旧纪录，增加新记录
            data.freq = UpdateFrequency(key, data.freq);

            // 返回缓存值
            return data.value;


        }

        // 传入旧纪录
        private LinkedListNode<Group> UpdateFrequency(int key, LinkedListNode<Group> old)
        {
            // 删除旧频率表的记录
            old.Value.record.Remove(key);

            // 获取新（高）频率表
            var current = old.Next;
            if (current == null || current.Value.freq > old.Value.freq + 1)
            {
                current = freq.AddAfter(old, new Group
                {
                    freq = old.Value.freq + 1,
                    record = new LinkedList<int>()
                });
            }

            if (old.Value.record.Count == 0) old.List.Remove(old);

            // 在新频率表追加记录
            current.Value.record.AddLast(key);

            // 返回新纪录
            return current;
        }
    }


    public class Data
    {
        public int value;
        public LinkedListNode<Group> freq;
    }

    public class Group
    {
        public int freq;
        public LinkedList<int> record;
    }
}