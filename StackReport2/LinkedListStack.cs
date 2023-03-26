using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackReport2
{
    internal class LinkedListStack
    {
        static void Main(string[] args)
        {
            LinkedList<int> stack = new LinkedList<int>();

            //push
            stack.AddLast(0);
            stack.AddLast(1);
            stack.AddLast(2);

            //pop
            Console.WriteLine(stack.Last.Value);
            stack.RemoveLast();
            Console.WriteLine(stack.Last.Value);
            stack.RemoveLast();
            Console.WriteLine(stack.Last.Value);
            stack.RemoveLast();
            Console.WriteLine(stack.Last.Value);

        }
    }
}
