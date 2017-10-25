using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Vertex<T>
    {
        public List<Vertex<T>> Neighbours { get; set; }

        public bool Explored { get; set; }
        public int Leader { get; set; }
    }
}
