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
            throw new System.NotImplementedException();
        }

        public object pop()
        {
            throw new System.NotImplementedException();
        }

        public void push(object e)
        {
            throw new System.NotImplementedException();
        }

        public int size()
        {
            return SIZE;
        }
        public object[] DATA() { return data; }
    }
}
