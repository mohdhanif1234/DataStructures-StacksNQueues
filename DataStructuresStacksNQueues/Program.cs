using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStacksNQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Welcome to  Stack and Queue");
            Console.WriteLine("****************************************************************");
            //Object of class LinkedListStack
            StackWithLinkedList stack = new StackWithLinkedList();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("After pushing some node into stack");
            stack.DisplayLL();
            Console.ReadLine();
        }
    }
}
