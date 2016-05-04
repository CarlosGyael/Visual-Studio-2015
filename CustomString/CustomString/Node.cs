using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class Node
    {
        private object data;
        private Node next;
        public Node(Object data)
        {
            this.data = data;
        }

        public Node(Object data, Node next)
        {
            this.data = data;
            this.next = next;
        }
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        
    }
}
