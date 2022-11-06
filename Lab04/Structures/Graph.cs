using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLab2
{
    public class Graph
    {
        public List<Graph_Node> Nodes { get; set; }
        public Graph()
        {
            Nodes = new List<Graph_Node>();
        }
        public void AddNode(Graph_Node node)
        {
            Nodes.Add(node);
        }

        public List<Graph_Node> GetNodes()
        {
            return Nodes;
        }
    }
}
