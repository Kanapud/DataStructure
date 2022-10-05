
namespace Stacks
{
    public interface Stack
    {
        bool isempty();
        int size();
        void push(object e);
        object peek();
        object pop();
    }
}
