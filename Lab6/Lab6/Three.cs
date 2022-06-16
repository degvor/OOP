using System.Collections.Generic;

namespace Lab6
{

    public class Tree
    {
        public Tree(int value)
        {
            Root = new Node(value);
        }

        public Node Root { get; }


        public void Insert(int value) => InsertHelper(value, Root);

        public string PreorderTraverse() => PreorderTraverseHelper(Root, new List<Node>());

        public int CountNegative()
        {
            int count = 0;
            CountNegativeHelper(ref count, Root);
            return count;
        }

        public int CountPositive()
        {
            int count = 0;
            CountPositiveHelper(ref count, Root);
            return count;
        }

        private void InsertHelper(int value, Node root)
        {
            if (value < root.Value)
            {
                if (root.Left == null)
                    root.Left = new Node(value);
                else InsertHelper(value, root.Left);
            }
            else if (value > root.Value)
            {
                if (root.Right == null)
                    root.Right = new Node(value);
                else InsertHelper(value, root.Right);
            }
        }

        private void CountNegativeHelper(ref int count, Node root)
        {
            if (root == null) return;
            if (root.Value >= 0)
            {
                CountNegativeHelper(ref count, root.Left);
            }
            else
            {
                count++;
                CountNegativeHelper(ref count, root.Right);
                CountNegativeHelper(ref count, root.Left);
            }
        }

        private void CountPositiveHelper(ref int count, Node root)
        {
            if (root == null) return;
            if (root.Value <= 0)
            {
                CountPositiveHelper(ref count, root.Right);
            }
            else
            {
                count++;
                CountPositiveHelper(ref count, root.Left);
                CountPositiveHelper(ref count, root.Right);
            }
        }

        private string PreorderTraverseHelper(Node root, List<Node> nodes)
        {
            nodes.Add(root);
            if (root.Left != null)
                PreorderTraverseHelper(root.Left, nodes);
            if (root.Right != null)
                PreorderTraverseHelper(root.Right, nodes);
            return string.Join(" ", nodes);
        }
    }
}