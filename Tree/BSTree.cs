using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BSTree : BinaryTree
    {
        private int SIZE;
        public object getMax()
        {
            Node r = root;
            if (r == null) return null;
            while (r.right != null)
                r = r.right;
            return r.e;
        }
        public object getMin()
        {
            Node r = root;
            if (r == null) return null;
            while (r.left != null)
                r = r.left;
            return r.e;
        }
        private Node add(Node r, object e)
        {
            if (r == null) { r = new Node(e, null, null); SIZE++; }
            else
            {
                int cmp = ((IComparable)e).CompareTo(r.e);
                if (cmp < 0)
                    r.left = add(r.left, e);
                else
                    r.right = add(r.right, e);
            }
            return r;
        }
        public void add(object e) { root = add(root, e); }
        private Node remove(Node r, object e)
        {
            if (r == null) return r;
            int cmp = ((IComparable)e).CompareTo(r.e);
            if (cmp < 0) r.left = remove(r.left, e);
            else if (cmp > 0) r.right = remove(r.right, e);
            else
            {
                if (r.left == null || r.right == null)
                {
                    r = r.left == null ? r.right : r.left;
                    SIZE--;
                }
                else
                {
                    Node m = r.right;
                    while (m.left != null)
                        m = m.left;
                    r.e = m.e;
                    r.right = remove(r.right, m.e);
                }
            }
            return r;
        }
        public void remove(object e)
        {
            root = remove(root, e);
        }
        private Node getNode(Node r, object e)
        {
            if (r == null) return null;
            int cmp = ((IComparable)e).CompareTo(r.e);
            if (cmp == 0) return r;
            if (cmp < 0) return getNode(r.left, e);
            else return getNode(r.right, e);
        }
        public bool contains(object e)
        {
            Node node = getNode(root, e);
            return node == null ? false : true;
        }
        public static void treeSoft(ref object[] x)
        {
            BSTree t = new BSTree();
            for (int i = 0; i < x.Length; i++)
                t.add(x[i]);
            x = t.toArray();
        }
    }
}
