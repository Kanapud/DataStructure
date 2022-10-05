
using Microsoft.SqlServer.Server;

namespace Stacks
{
    public class LinkedStack : Stack
    {
        private class LinkedNode
        {
            public object e;
            public LinkedNode next;
            public LinkedNode(object e, LinkedNode next)
            {
                this.e = e;
                this.next = next;
            }
        }
        private LinkedNode first;
        private int SIZE;
        

        public bool isempty()
        {
            return SIZE == 0;  
        }

        public object peek()
        {
            throw new System.NotImplementedException();
        }

        public object pop()
        {
            throw new System.NotImplementedException();
        }

        public void push(object e)
        {
            data[SIZE++] = e;
        }

        public int size()
        {
            return SIZE;
        }
    }
}
