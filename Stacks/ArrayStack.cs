namespace Stacks
{
    public class ArrayStack : Stack
    {
        private object[] data;
        private int SIZE;
        private int cap;

        public ArrayStack(int cap) 
        {
            
        }
        public bool isempty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            if (SIZE == 0)
                throw new System.MissingMemberException();
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
            ensureCapacity();
            data[SIZE++] = e;
        }

        private void ensureCapacity()
        {
            if (SIZE + 1 > data.Length)
            {
                object[] tempdata = new object[SIZE * 2];
                for (int i = 0; i < SIZE; i++)
                    tempdata[i] = data[i];
                data = tempdata;
            }
        }

                public int size()
        {
            return SIZE;
        }
        public object[] DATA() { return data; }
    }
}
