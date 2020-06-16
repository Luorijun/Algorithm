using System;

namespace leetcode_297
{
    class Program
    {
        static void Main(string[] args)
        {
            var codec = new Codec();
            Console.WriteLine(codec.serialize(codec.deserialize("null")));
            Console.WriteLine(codec.serialize(codec.deserialize("1,2,3,null,7,4,5")));
            Console.WriteLine(codec.serialize(codec.deserialize("1,2,3,6,null,4,5")));
            Console.WriteLine(codec.serialize(codec.deserialize("1,2,3,null,null,4,5")));
            Console.WriteLine(codec.serialize(codec.deserialize("1,null,3,2,null,4,5")));
            Console.WriteLine(codec.serialize(codec.deserialize("1 ,null , 3 ,null , 2,null ,5 , null")));
        }
    }
}