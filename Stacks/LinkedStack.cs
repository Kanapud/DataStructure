
using Microsoft.SqlServer.Server;
using System;

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
            if(isempty())
                throw new System.MissingMemberException();
            return first.e;
        }

        public object pop()
        {
            object e = peek();
            first = first.next;
            SIZE--;
            return e;   
        }

        public void push(object e)
        {
            first = new LinkedNode(e, first);
            SIZE++;
        }

        public int size()
        {
            return SIZE;
        }
    }
}
