using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStacksNQueues
{
    class Stack
    {
        public static void StackMethod()
        {
            //Object of class StackWithLinkedList
            StackWithLinkedList stack = new StackWithLinkedList();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("After pushing some node into stack");
            stack.DisplayLL();
            Console.WriteLine("\n****************************************************************");
            //Find the Top most element of the stack i.e. Peek
            int peekValue = stack.Peek();
            Console.WriteLine("Peek value of stack is " + peekValue);
            stack.DisplayLL();
            Console.WriteLine("****************************************************************\n");
            //Pop the element from the stack one by one till satck empty
            Console.WriteLine("Pop value of stack are ");
            stack.Pop();
            Console.WriteLine("\n****************************************************************");
        }
    }
}
