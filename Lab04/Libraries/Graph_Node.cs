using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLab2
{
    public class Graph_Node
    {
        public int Distance { get; set; }
        public Graph_Node parent { get; set; }
        public Graph_Node(string value, int distance = 0, Graph_Node parent = null)
        {
            Distance = distance;
            this.parent = parent;
            Adjacents = new List<Graph_Node>();
            Value = value;
        }

        public List<Graph_Node> Adjacents { get; set; }
        public void AddAdjacents(Graph_Node node)
        {
            Adjacents.Add(node);
        }
        public string Value { get; set; }

        public List<Graph_Node> GetGraph_Nodes()
        {
            return Adjacents;
        }
    }
}
