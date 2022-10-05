using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Collections;

namespace Sets
{
    public class ArraySet : ArrayCollection,Set
    {
        public ArraySet(int cap) : base(cap)
        {
        }

        public new void add(object e)
        {
            if (!contains(e))
                base.add(e);
        }  
    }
}
