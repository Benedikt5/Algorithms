using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class DiGraph<T> : BaseGraph<T>
    {
        protected DiGraph(IEnumerable<GraphNode<T>> nodes) : base(nodes)
        {
        }

        public override void AddEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbours.Add(to);
            from.Costs.Add(cost);
        }
    }
}
