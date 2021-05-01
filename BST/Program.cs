using BSTs;
using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {

            var bstTest = new BST<int>();
            bstTest.Insert(value: 37);
            bstTest.Insert(value: 12);
            bstTest.Insert(value: 4);
            bstTest.Insert(value: 45);
            bstTest.Insert(value: 34);
            bstTest.Insert(value: 78);
            bstTest.Insert(value: 33);
            bstTest.Insert(value: 25);
            bstTest.Insert(value: 61);
            bstTest.Insert(value: 32);

            foreach(var i in bstTest.TraverseInOrder())
            {
                Console.WriteLine(value: $"{i}");
            }
            Console.WriteLine();
            Console.WriteLine(bstTest.Min());
            Console.WriteLine(bstTest.max());
            Console.WriteLine(bstTest.Get(78).Value);
            Console.Read();




            
        }
    }
}
