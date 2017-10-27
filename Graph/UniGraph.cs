using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public class UniGraph<T> : BaseGraph<T>
    {
        protected UniGraph(IEnumerable<GraphNode<T>> nodes) : base(nodes)
        {
        }

        public override void AddEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbours.Add(to);
            from.Costs.Add(cost);
            to.Neighbours.Add(from);
            to.Costs.Add(cost);

        }

        
    }
}
