using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    internal class AdjancencyMatrix
    {
        public int[] visited { get; set; }
        public Edge[,] mat { get; set; }
        public int[] ccNum { get; set; }
        public int cc { get; set; } = 0;
        public int[] preOrder { get; set; }
        public int[] postOrder { get; set; }
        public AdjancencyMatrix(int x)
        {
            preOrder = new int[x];
            postOrder = new int[x];
            ccNum = new int[x];
            visited = new int[x];
            mat = new Edge[x, x];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    mat[i, j] = new Edge(i, j);
                }
            }
        }
        public void AddEdge(int v1, int v2)
        {
            mat[v1, v2].value = 1;
        }
        public bool isEdge(int v1, int v2)
        {
            return mat[v1, v2].value == 1;
        }
        public List<Edge> ListEdge()
        {
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j].value == 1)
                    {
                        edges.Add(new Edge(i, j));
                    }
                }
            }
            return edges;
        }
        public List<int> ListNeighbors(int j)
        {
            List<int> neighbors = new List<int>();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (mat[j, i].value == 1)
                    neighbors.Add(i);
            }
            return neighbors;
        }
        public int[] explore(int v)
        {
            int[] arr = new int[this.mat.GetLength(0)];
            explore(arr, v);
            return arr;
        }
        public void explore(int[] arr, int v)
        {
            if (arr[v] == 1)
                return;
            arr[v] = 1;
            ccNum[v] = cc;
            List<int> l = ListNeighbors(v);
            foreach (int item in l)
            {
                explore(arr, item);
            }
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
    }
}
