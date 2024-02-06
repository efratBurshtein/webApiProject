namespace graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdjancencyMatrix m1 = new AdjancencyMatrix(5);
            m1.AddEdge(2, 4);
            m1.AddEdge(3, 4);
            m1.AddEdge(4, 1);
            m1.AddEdge(1, 3);
            Console.WriteLine(m1.isEdge(2,4));
            Console.WriteLine(m1.isEdge(0, 3));
            List<Edge> l= m1.ListEdge();
            foreach (Edge item in l)
            {
                Console.WriteLine(item);
            }
            List<int> l1 = m1.ListNeighbors(4);
            foreach (int item in l1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine( "++++++++++++++++++++++++++" );
            m1.DFS();
            for (int i = 0; i < m1.ccNum.Length; i++)
            {
                Console.WriteLine(m1.ccNum[i]);
            }

        }
    }
}