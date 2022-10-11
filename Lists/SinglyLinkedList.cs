

namespace Lists
{
    public class SinglyLinkedList : List
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
        public void add(int index, object e)
        {
            if (index > SIZE) throw new System.IndexOutOfRangeException();
            LinkedNode node = nodeAt(index - 1);
            node.next = new LinkedNode(e, node.next);
            SIZE++;
        }
        private void removeAfter(LinkedNode node)
        {
            if (node.next != null)
            {
                node.next = node.next.next;
                SIZE--;
            }
        }

        public void add(object e)
        {
            add(SIZE, e);
        }

        public bool contains(object e)
        {
            return indexOf(e) > -1;
        }

        public object get(int index)
        {
            return nodeAt(index).e;
        }
        private LinkedNode nodeAt(int index)
        {
            LinkedNode node = first;
            for (int i = -1; i < index; i++)
                node = node.next;
            return node;
        }
            
        public int indexOf(object e)
        {
            LinkedNode node = first.next;
            for (int i = 0; i < SIZE; i++)
            {
                if (node.e.Equals(e)) return i;
                node = node.next;
            }
            return -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(int index)
        {
            LinkedNode node = nodeAt(index - 1);
            removeAfter(node);
        }

        public void remove(object e)
        {
            LinkedNode node = first;
            while (node.next != null && !node.next.e.Equals(e))
                node = node.next;
            removeAfter(node);
        }

        public void set(int index, object e)
        {
            nodeAt(index).e = e;
        }

        public int size()
        {
            return SIZE;
        }
    }
}
