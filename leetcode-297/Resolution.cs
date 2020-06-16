using System.Collections.Generic;

namespace leetcode_297
{
    // Definition for a binary tree node.
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

    public class Codec
    {
        public string serialize(TreeNode root)
        {
            var list = new List<string>();
            var nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            var count = root == null ? 0 : 1;
            do
            {
                var node = nodes.Dequeue();

                if (node == null) list.Add("null");
                else
                {
                    count--;
                    list.Add(node.val.ToString());

                    nodes.Enqueue(node.left);
                    nodes.Enqueue(node.right);
                    if (node.left != null) count++;
                    if (node.right != null) count++;
                }
            } while (count != 0);

            return string.Join(',', list);
        }

        public TreeNode deserialize(string data)
        {
            if (data == "null") return null;

            var array = data.Split(',');
            var nodes = new Queue<TreeNode>();

            var root = new TreeNode(int.Parse(array[0].Trim()));
            nodes.Enqueue(root);
            var c = 0;

            for (var i = 1; i < array.Length; i++)
            {
                var v = array[i].Trim();
                if (v == "null")
                    if (c == 0) nodes.Peek().left = null;
                    else nodes.Dequeue().right = null;
                else
                {
                    var n = int.Parse(v);
                    if (c == 0)
                    {
                        nodes.Peek().left = new TreeNode(int.Parse(v));
                        nodes.Enqueue(nodes.Peek().left);
                    }
                    else
                    {
                        nodes.Peek().right = new TreeNode(int.Parse(v));
                        nodes.Enqueue(nodes.Dequeue().right);
                    }
                }
                c = c == 0 ? 1 : 0;
            }
            return root;
        }
    }
}