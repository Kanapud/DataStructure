

namespace Lists
{
    public class LinkedList : List
    {
        private class LinkedNode
        {
            public object e;
            public LinkedNode next;
            public LinkedNode back;
            public LinkedNode(object e, LinkedNode next, LinkedNode back)
            {
                this.e = e;
                this.next = next;
                this.back = back;
            }
        }
        private LinkedNode first = new LinkedNode(null, null, null);
        private int SIZE;
        public LinkedList()
        {
            first.back = first.next = first;
        }
        private void addBefore(LinkedNode node, object e) 
        {
            LinkedNode before = node.back;
            LinkedNode here = new LinkedNode(e, before, node);
            before.next = node.back = here;
            SIZE++;
        }
        private LinkedNode nodeAt(int index)
        {
            LinkedNode node = first;
            for (int i = -1; i < index; i++)
                node = node.next;
            return node;
        }
        public void add(int index, object e)
        {
            addBefore(nodeAt(index), e);
        }

        public void add(object e)
        {
            addBefore(first, e);
        }

        public bool contains(object e)
        {
            return indexOf(e) > -1;
        }

        public object get(int index)
        {
            return nodeAt(index).e;
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
        private void removeNode(LinkedNode node) 
        {
            LinkedNode before = node.back;
            LinkedNode after = node.next;
            before.next = after;
            after.back = before;
            SIZE--; 
        }

        public void remove(int index)
        {
            removeNode(nodeAt(index));
        }

        public void remove(object e)
        {
            LinkedNode node = first.next;
            while (node != first)
            {
                if (node.e.Equals(e))
                {
                    removeNode(node);
                    break;
                }
                node = node.next;
            }
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
