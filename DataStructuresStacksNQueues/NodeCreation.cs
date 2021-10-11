using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresStacksNQueues
{
    class NodeCreation
    {   
        //Intialize instance variable of class
        public NodeCreation next;
        public int data;
        /// <summary>
        /// constructor called to create a node
        /// </summary>
        /// <param name="value"></param>
        public NodeCreation(int value)
        {
            this.data = value;
        }
    }
}
