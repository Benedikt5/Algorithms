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

        public List<int> Costs
        {
            get
            {
                _costs = _costs ?? new List<int>();
                return _costs;
            }
        }
        private List<int> _costs;
    }
}
