using Collections;

namespace Sets
{
    public class LinkedSet : LinkedCollection, Set
    {
        public new void add(object e) 
        {
            if (!contains(e))
                base.add(e);
        }
    }
}
