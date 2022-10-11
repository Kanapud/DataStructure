namespace Stacks
{
    public class LinkedStack : Stack
    {
        int SIZE;
        private LinkedNode first;
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

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            if (isEmpty())
                throw new System.MissingMemberException();
            return first;
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
