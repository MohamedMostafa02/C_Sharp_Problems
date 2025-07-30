using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Graph.Graph;

namespace Graph
{
    class Graph
    {
        public enum enGraphDirectionType { Directed, unDirected }


        private int[,] _adjacencyMatrix;

        private Dictionary<string, int> _vertexDictionary;

        private int _numberOfVertices;
        private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.unDirected;

        public Graph(List<string> vertices, enGraphDirectionType graphDirectionType)
        {
            _GraphDirectionType = graphDirectionType;

            _numberOfVertices = vertices.Count;

            _adjacencyMatrix = new int[_numberOfVertices, _numberOfVertices];

            _vertexDictionary = new Dictionary<string, int>();

            for (int i = 0; i < vertices.Count; i++)
            {
                //populate The Dictionary with vertices (e.g.,'A' -> 0, 'B' -> 1,etc.)
                _vertexDictionary[vertices[i]] = i;
            }
        }

        public void AddEdge(string source, string destination, int wieght)
        {
            if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = _vertexDictionary[source];
                int destinationIndex = _vertexDictionary[destination];

                _adjacencyMatrix[sourceIndex, destinationIndex] = wieght;

                if (_GraphDirectionType == enGraphDirectionType.unDirected)
                {
                    _adjacencyMatrix[destinationIndex, sourceIndex] = wieght;
                }
            }
            else
            {
                Console.WriteLine($"\n\nIgnored:Invalid verices.{source} ==> {destination}\n\n");
            }
        }

        public void RemoveEdge(string souce, string destination)
        {
            if (_vertexDictionary.ContainsKey(souce) && _vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = _vertexDictionary[souce];
                int destinationIndex = _vertexDictionary[destination];

                _adjacencyMatrix[sourceIndex, destinationIndex] = 0;
            }
            else
            {
                Console.WriteLine($"\n There is no Edge Between {souce} and {destination}\n\n");
            }
        }

        public void DisplayGraph(string message)
        {
            Console.WriteLine("\n" + message + "\n");

            Console.Write("  ");
            foreach (var vertex in _vertexDictionary.Keys)
            {
                Console.Write(vertex + " ");
            }
            Console.WriteLine();

            foreach (var source in _vertexDictionary)
            {
                Console.Write(source.Key + " ");

                for (int j = 0; j < _numberOfVertices; j++)
                {
                    Console.Write(_adjacencyMatrix[source.Value, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool IsEdge(string source, string destination)
        {
            if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
            {
                int sourceIndex = _vertexDictionary[source];
                int destinationIndex = _vertexDictionary[destination];

                return _adjacencyMatrix[sourceIndex, destinationIndex] > 0;
            }
            return false;
        }

        public int GetInDegree(string vertex)
        {
            int degree = 0;

            if (_vertexDictionary.ContainsKey(vertex))
            {
                int vertexIndex = _vertexDictionary[vertex];

                for (int i = 0; i < _numberOfVertices; i++)
                {
                    if (_adjacencyMatrix[i, vertexIndex] > 0)
                        degree++;
                }
            }
            return degree;

        }

        public int GetOutDegree(string vertex)
        {
            int degree = 0;

            if (_vertexDictionary.ContainsKey(vertex))
            {
                int vertexIndex = _vertexDictionary[vertex];

                for (int i = 0; i < _numberOfVertices; i++)
                {
                    if (_adjacencyMatrix[vertexIndex, i] > 0)
                        degree++;
                }

            }
            return degree;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vertices = new List<string>() { "A", "B", "C", "D", "E" };

            Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

            graph1.AddEdge("A", "B", 1);
            graph1.AddEdge("A", "C", 1);
            graph1.AddEdge("B", "D", 1);
            graph1.AddEdge("C", "D", 1);
            graph1.AddEdge("B", "E", 1);
            graph1.AddEdge("D", "E", 1);

            graph1.AddEdge("E", "F", 1);

            graph1.DisplayGraph("Adjacency Matrix For Example1 (unDirected Graph):");

            Console.WriteLine("\n------------------------------------\n");

            Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

            graph2.AddEdge("A", "A", 1);
            graph2.AddEdge("A", "B", 1);
            graph2.AddEdge("A", "C", 1);
            graph2.AddEdge("B", "E", 1);
            graph2.AddEdge("D", "B", 1);
            graph2.AddEdge("D", "C", 1);
            graph2.AddEdge("D", "E", 1);

            graph2.DisplayGraph("Adjacency Matrix for Example2 (Dirtected Graph):");

            Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));
            Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));

            Console.WriteLine("\n------------------------------------\n");

            Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

            graph3.AddEdge("A", "B", 5);
            graph3.AddEdge("A", "C", 3);
            graph3.AddEdge("B", "D", 12);
            graph3.AddEdge("C", "D", 10);
            graph3.AddEdge("B", "E", 2);
            graph3.AddEdge("D", "E", 7);

            graph3.DisplayGraph("Adjacency Matrix for Example3 (Weighted Grpah):");

            Console.WriteLine("\nIS there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));
            Console.WriteLine("\nIS there an edge between B and C in Graph3? " + graph3.IsEdge("B", "C"));
            Console.WriteLine("\nIS there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));
            Console.WriteLine("\nIS there an edge between A and D in Graph3? " + graph3.IsEdge("A", "D"));

            Console.WriteLine("\nInDegree of vertex A: " + graph3.GetInDegree("A"));
            Console.WriteLine("\nOutDegree of vertex A: " + graph3.GetOutDegree("A"));

            Console.WriteLine("\n------------------------------------\n");


            Console.WriteLine("\nRemoving Edge between E and D:");

            graph3.RemoveEdge("E", "D");
            graph3.DisplayGraph("After Removing Edge between E and D:");

            Console.WriteLine("\nIS there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));

            Console.ReadKey();


        }
    }
}
