using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    internal class AdjancencyList
    {
        public int[] visited { get; set; }
        public List<Edge>[] arr { get; set; }
        public int[] ccNum { get; set; }
        public int cc { get; set; } = 0;
        public int timmer { get; set; } = 0;
        public int[] preOrder { get; set; }
        public int[] postOrder { get; set; }
        public AdjancencyList(int x)
        {
            ccNum = new int[x];
            arr = new List<Edge>[x];
            visited = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new List<Edge>();
            }
        }
        public void AddEdge(int v1, int v2)
        {
            arr[v1].Add(new Edge(v1, v2));
        }
        public bool isEdge(int v1, int v2)
        {
            return arr[v1].Any(x => x.y == v2);
        }
        public List<Edge> ListEdge()
        {
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (Edge item in arr[i])
                {
                    edges.Add(item);
                }
            }
            return edges;
        }
        public List<int> ListNeighbors(int j)
        {
            List<int> neighbors = new List<int>();
            foreach (Edge item in arr[j])
            {
                neighbors.Add(item.y);
            }
            return neighbors;
        }
        public int[] explore(int v)
        {
            int[] arr = new int[this.arr.Length];
            explore(arr, v);
            return arr;
        }
        public void explore(int[] arr, int v)
        {
            if (arr[v] == 1)
                return;
            arr[v] = 1;
            ccNum[v] = cc;
            preOrder[v] = timmer++;
            foreach (Edge item in this.arr[v])
            {
                explore(arr, item.y);
            }
            postOrder[v] = timmer++;
        }
        public void DFS()
        {
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] != 1)
                {
                    explore(visited, i);
                    cc++;
                }
            }
        }
        //public List<int> TopologicalSort()
        //{
        //    int[]t=new int[this.arr.Length];
        //    List<int> topologySort = new List<int>();
        //    DFS();

        //    return t.ToList();
        //}
    }
}
