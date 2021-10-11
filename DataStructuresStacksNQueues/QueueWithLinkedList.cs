using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStacksNQueues
{
    class QueueWithLinkedList
    {   
        //Initialize the head of the LL
        internal NodeCreation frontNode, rearNode;
        public void Enqueue(int value)
        {
            NodeCreation queueNode = new NodeCreation(value);
            if (this.rearNode == null)
            {
                this.frontNode = queueNode;
                this.rearNode = queueNode;
            }
            else
            {
                this.rearNode.next = queueNode;
                this.rearNode = queueNode;
            }

        }
        public void DisplayLL()
        {
            NodeCreation temp = frontNode;
            if (temp == null)
            {
                Console.WriteLine("Given queue is empty");
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Display all the value of queue");
            Console.WriteLine("****************************************************************");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
        public int Dequeue()
        {

            if (this.frontNode == null)
            {
                Console.WriteLine("Queue is empty");
                return frontNode.data;
            }
            else
            {
                NodeCreation temp = frontNode;
                this.frontNode = frontNode.next;
                return temp.data;
            }
            if (frontNode == null)
            {
                this.rearNode = null;
            }

        }
    }
}
