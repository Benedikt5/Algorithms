using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Node<T>
    {
        public Node() { }
        public Node(T data) : this(data, null) { }
        public Node(T data, IList<T> neighbours)
        {
            Value = data;
            Neighbours = neighbours;
        }

        public IList<T> Neighbours { get; set; } = new List<T>();
        public T Value { get; set; }
    }
}
