
namespace Queues
{
    public interface Queue
    {
        bool isEmpty();
        int size();
        void enqueue(object e);
        object dequeue();
        object peek(); 
    }
}
