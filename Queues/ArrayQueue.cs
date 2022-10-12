using System.Runtime.ExceptionServices;

namespace Queues
{
    public class ArrayQueue : Queue
    {
        private object[] data;
        private int SIZE;
        private int cap;
        private int firstindex;
        public ArrayQueue(int cap)
        {
            this.cap = cap;
            data = new object[cap];
        }
        public object dequeue()

        {
            object e = peek();
            data[firstindex] = null;
            firstindex = (firstindex + 1) % data.Length;
            SIZE--; 
            return e;
        }

        public void enqueue(object e)
        {
            int k = (firstindex + SIZE) % data.Length;
            data[k] = e;
            SIZE++;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            if(isEmpty()) throw new System.MissingMemberException();
            return data[firstindex];
        }

        public int size()
        {
            return SIZE;
        }
    }
}
