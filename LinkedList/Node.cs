using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node
    {
        public int data;
        public Node nextNode = null;
        public Node(int data, Node nextNode)
        {
            this.data = data;
            this.nextNode = nextNode;
        }
    }
}
