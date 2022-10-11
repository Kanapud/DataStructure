using Collections;

namespace Sets
{
    public class Arrayset : ArrayCollection, Set 
    {
        public Arrayset(int cap) : base(cap)
        {
        }

        public new void add(object e)
        {
            if (!contains(e))
                base.add(e);
        }     
    }
}
