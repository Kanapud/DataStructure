using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class LinkedHeaderCollection : Collection
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
        private LinkedNode first = new LinkedNode(null,null);
        private int SIZE;
        public object[] ToAraay()
        {
            object[] x = new object[SIZE];
            LinkedNode node = first.next;
            int i = 0;
            while (node != null)
            {
                x[i++] = node.e;
                node = node.next;
            }
            return x;
        }
        public void add(object e)
        {
            first = new LinkedNode(e, first.next);
            SIZE++;
        }

        public bool contains(object e)
        {
            LinkedNode node = first.next;
            while (node != null)
            {
                if (node.e.Equals(e)) return true;
                node = node.next;
            }
            return false;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(object e)
        {
            LinkedNode node = first;
            while (node.next != null)
            {
                if (node.next.e.Equals(e))
                {
                    node.next = node.next.next;
                    SIZE--; return;
                }
                node = node.next;
            }
        }

        public int size()
        {
            return SIZE;
        }
    }
}
