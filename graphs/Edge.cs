using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    internal class Edge
    {
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
        public Edge(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.value = 0;
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}
