using System;
namespace ArrayBox
{
    public class ArrayBox : Box
    {
        int SIZE;
        int cap;
        int[] data;
        int sum;
        public ArrayBox(int cap)
        {
            this.cap = cap;
            data = new int[cap];
        }
        public void add(int e)
        {
            sum += e;
            data[SIZE++] = e;
        }

        public bool isEmty()
        {
            return SIZE == 0;
        }

        public void remove(int e)
        {
            data[SIZE] -= e;
        }

        public int size()
        {
            return SIZE;
        }

        public void view()
        {
            if (isEmty())
            {
                Console.WriteLine("Empty");
                return;
            }
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(data[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
