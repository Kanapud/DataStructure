using System;

namespace Tree
{
    public class BinaryTree
    {
        protected Node root;
        public class Node
        {
            public object e;
            public Node left, right;
            public Node(object e, Node left, Node right)
            {
                this.e = e;
                this.left = left;
                this.right = right;
            }
        }
        public int numNodes()
        {
            return numNodes(root);
        }
        private int numNodes(Node node)
        {
            if (node == null) return 0;
            return 1 + numNodes(node.left) + numNodes(node.right);
        }
        public int depth()
        {
            return depth(root);
        }
        private int depth(Node node)
        {
            if (node == null) return -1;
            return 1 + Math.Max(depth(node.left), depth(node.right));
        }
        public object[] toArray()
        {
            object[] a = new object[numNodes()];
            toArray(root, a, 0);
            return a;
        }
        private int toArray(Node node, object[] a, int k)
        {
            if (node == null) return k;
            k = toArray(node.left, a, k);
            a[k++] = node.e;
            k = toArray(node.right, a, k);
            return k;
        }
        public void generateTree()
        {
            root = new Node('A',
                new Node('B', new Node('D', null, null), null),
                new Node('C', null, null)
                );
        }
    }
}
