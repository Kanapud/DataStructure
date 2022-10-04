
namespace Collections
{
    public interface Collection
    {
        void add(object e);
        void remove(object e);
        bool contains(object e);
        int size();
        bool isEmpty();
    }
}
