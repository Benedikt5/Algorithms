using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Node<T>
    {
        public Node() { }
        public Node(T data) : this(data, null) { }
        public Node(T data, IList<Node<T>> neighbours)
        {
            Value = data;
            Neighbours = neighbours;
        }

        public IList<Node<T>> Neighbours { get; set; } = new List<Node<T>>();
        public T Value { get; set; }
    }
}
