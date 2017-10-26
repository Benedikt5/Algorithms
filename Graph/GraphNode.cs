using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class GraphNode<T> : Node<T>
    {
        public GraphNode() : base() { }

        public GraphNode(T value) : base(value) { }

        public GraphNode(T value, IList<T> neighbours) : base(value, neighbours) { }

        private List<int> costs;
    }
}
