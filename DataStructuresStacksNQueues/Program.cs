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
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Press 1 : for Queue\nPress 0 : to exit");
            Console.WriteLine("****************************************************************\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("Welcome to  Queue");
                    Console.WriteLine("****************************************************************\n");
                    Queue.QueueMethod();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
