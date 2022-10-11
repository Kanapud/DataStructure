using System;

namespace Stacks
{
    public class ArrayStack : Stack
    {
        object[] data;
        int SIZE;
        int cap;
        public ArrayStack(int cap) 
        {
            this.cap = cap;
            data = new object[cap];
        }

        public object[] DATA() 
        {
            return data;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }
        public object peek()
        {
            if (SIZE == 0)
                throw new System.InsufficientMemoryException();
            return data[SIZE - 1];
        }

        public object pop()
        {
            object e = peek();
            data[--SIZE] = null;
            return e;
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
