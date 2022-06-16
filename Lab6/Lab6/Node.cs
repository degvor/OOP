namespace Lab6
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }

        public int Value { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public override string ToString() => $"({Value})";
    }

}