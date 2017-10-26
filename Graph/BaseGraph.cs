using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public abstract class BaseGraph<T>
    {
        private List<GraphNode<T>> _nodes;
        protected BaseGraph(IEnumerable<GraphNode<T>> nodes)
        {
            _nodes = nodes != null ? nodes.ToList() : new List<GraphNode<T>>();
        }

        public void AddNode(T node)
        {
            _nodes.Add(new GraphNode<T>(node));
        }

        public abstract void AddEdge(GraphNode<T> from, GraphNode<T> to, int cost);

        public bool Contains(T value)
        {
            return _nodes.Any(x => x.Value.Equals(value));
        }

        public bool RemoveNode(T value)
        {
            var nodeToRemove = _nodes.FirstOrDefault(x => x.Value.Equals(value));
            if (nodeToRemove == null)
                return false;

            _nodes.Remove(nodeToRemove);

            _nodes.ForEach(x =>
            {
                var index = x.Neighbours.IndexOf(value);
                if (index != -1)
                {
                    x.Neighbours.RemoveAt(index);
                    x.Costs.RemoveAt(index);
                }
            });

            return true;
        }

public List<GraphNode<T>> Nodes
        {
            get { return _nodes; }
        }
        public int Count
        {
            get { return _nodes.Count; }
        }
    }
}
