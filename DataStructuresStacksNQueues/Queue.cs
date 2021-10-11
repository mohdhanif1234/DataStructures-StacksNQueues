﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStacksNQueues
{
    class Queue
    {
        public static void QueueMethod()
        {
            //Create an object of LinkedListQueue class
            QueueWithLinkedList queue = new QueueWithLinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("After enqueue some node into queue");
            queue.DisplayLL();
            Console.WriteLine("****************************************************************");
        }
    }
}
