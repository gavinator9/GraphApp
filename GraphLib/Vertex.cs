﻿namespace GraphLib
{
    public class Vertex
    {
        public string Label { get; set; }
        public List<Edge> Edges = new List<Edge>();

        public Vertex(string lbl)
        {
            Label = lbl;
        }

        public Vertex AddEdge(Vertex child, int weight)
        {
            Edges.Add(new Edge
            {
                Parent = this,
                Child = child,
                Weight = weight
            });

            
            if (!Edges.Exists(e => e.Parent == child && e.Child == this))
            {
                
                Edges.Add(new Edge
                {
                    Parent = child,
                    Child = this,
                    Weight = weight
                });
            }

            return this;
        }
    }
}