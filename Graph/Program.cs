namespace Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph listGraph = new ListGraph(8);

            listGraph.ConnectBoth(0, 1);
            listGraph.ConnectBoth(0, 2);

            listGraph.ConnectBoth(3, 5);
            listGraph.ConnectBoth(3, 7);

            listGraph.ConnectBoth(4, 6);
            listGraph.ConnectBoth(4, 7);

            listGraph.ConnectBoth(5, 6);

            Console.WriteLine("인접리스트 그래프\n");
            listGraph.PrintGraph();

            Console.WriteLine();
            Console.WriteLine();
            //---------------------------------------------
            Graph matrixGraph = new MatrixGraph(8);

            matrixGraph.ConnectBoth(0, 1);
            matrixGraph.ConnectBoth(0, 2);

            matrixGraph.ConnectBoth(3, 5);
            matrixGraph.ConnectBoth(3, 7);

            matrixGraph.ConnectBoth(4, 6);
            matrixGraph.ConnectBoth(4, 7);

            matrixGraph.ConnectBoth(5, 6);

            Console.WriteLine("인접행렬 그래프\n");
            matrixGraph.PrintGraph();
        }
    }

    public abstract class Graph
    {
        public int vertex;

        public Graph(int _vertex)
        {
            this.vertex = _vertex;
        }

        public abstract void Connect(int from, int to);
        public abstract void ConnectBoth(int from, int to);
        public abstract void DisConnect(int from, int to);
        public abstract bool IsConnect(int from, int to);

        public abstract void PrintGraph();
    }

    public class ListGraph : Graph
    {
        public List<int>[] graph;

        public ListGraph(int vertex) : base(vertex)
        {
            graph = new List<int>[vertex];
            for (int i = 0; i < vertex; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public override void Connect(int from, int to)
        {
            graph[from].Add(to);
        }

        public override void ConnectBoth(int from, int to)
        {
            graph[from].Add(to);
            graph[to].Add(from);
        }

        public override void DisConnect(int from, int to)
        {
            graph[from].Remove(to);
        }

        public override bool IsConnect(int from, int to)
        {
            return graph[from].Contains(to);
        }

        public override void PrintGraph()
        {
            for(int from = 0; from < vertex; from++)
            {
                Console.WriteLine($"{from} 노드 :");
                for (int to = 0; to < vertex; to++)
                {
                    if (IsConnect(from, to))
                    {
                        Console.WriteLine($"  {to} 노드");
                    }
                }
                Console.WriteLine("=========");
            }
        }
    }

    public class MatrixGraph : Graph
    {
        public bool[,] graph;

        public MatrixGraph(int vertex) : base(vertex)
        {
            graph = new bool[vertex, vertex];
        }

        public override void Connect(int from, int to)
        {
            graph[from, to] = true;
        }

        public override void ConnectBoth(int from, int to)
        {
            graph[from, to] = true;
            graph[to, from] = true;
        }

        public override void DisConnect(int from, int to)
        {
            graph[from, to] = false;
        }

        public override bool IsConnect(int from, int to)
        {
            return graph[from, to];
        }

        public override void PrintGraph()
        {
            for (int from = 0; from < vertex; from++)
            {
                Console.WriteLine($"{from} 노드 : ");
                for (int to = 0; to < vertex; to++)
                {
                    if (graph[from, to])
                    {
                        Console.WriteLine($"  {to} 노드");
                    }
                }
                Console.WriteLine("---------");
            }
        }
    }
}
