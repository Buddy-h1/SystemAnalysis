using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopologicalDecompositionGraph
{
    static class TopologicalDecompositionGraph
    {
        public class Subgraph
        {
            public Subgraph()
            {
                Vertex = new List<int>();
                Arc = new List<int>();
                ListLeftIncidents = new List<int>();
            }

            public int NumberSubgraph;
            public List<int> Vertex { get; set; }
            public List<int> Arc { get; set; }
            public List<int> ListLeftIncidents { get; set; }
        }

        public class DecomposedGraph
        {
            public DecomposedGraph()
            {
                Subgraphs = new List<Subgraph>();
            }

            public List<Subgraph> Subgraphs { get; set; }

            public int[,] IncidenceMatrix { get; set; }
        }

        private static List<int> GetAttainableList(int[,] incidenceMatrix, bool counter)
        {
            //Начальная матрица инцидентности
            int incidenceMatrixRow = incidenceMatrix.GetUpperBound(0) + 1;
            int incidenceMatrixColumn = incidenceMatrix.Length / incidenceMatrixRow;

            //Проверка - если не осталось свободных вершин
            bool flag = true;
            for (int i = 0; i < incidenceMatrixRow; i++)
            {
                if (incidenceMatrix[i, 0] != 5)
                {
                    flag = false;
                    break;
                }
            }
            if (flag) return new List<int>();

            int markerVertex;
            int markerArc;

            if (counter)
            {
                markerVertex = 1;
                markerArc = -1;
            }
            else
            {
                markerVertex = -1;
                markerArc = 1;
            }

            //Определение первой оставшейся вершины
            int startIndex;
            for (startIndex = 0; startIndex < incidenceMatrixRow; startIndex++)
            {
                if (incidenceMatrix[startIndex, 0] == 5) continue;
                else break;
            }

            //Первая итерация - Заполнение первых двух уровней соседними вершинами
            List<List<int>> vertexByLevel = new List<List<int>>();
            vertexByLevel.Add(new List<int>());
            vertexByLevel[0].Add(startIndex);
            vertexByLevel.Add(new List<int>());
            for (int i = 0; i < incidenceMatrixColumn; i++)
            {
                if (incidenceMatrix[startIndex, i] == markerVertex)
                {
                    for (int j = 0; j < incidenceMatrixRow; j++)
                    {
                        if (incidenceMatrix[j, i] == markerArc)
                        {
                            vertexByLevel[1].Add(j);
                            break;
                        }
                    }
                }
                incidenceMatrix[startIndex, i] = 5;
            }

            while (true)
            {
                //Проверка
                if (vertexByLevel.Last().Count == 0) break;

                vertexByLevel.Add(new List<int>());
                foreach (var vertexInLevel in vertexByLevel[vertexByLevel.Count - 2])
                {
                    if (incidenceMatrix[vertexInLevel, 0] == 5) continue;
                    else
                    {
                        for (int j = 0; j < incidenceMatrixColumn; j++)
                        {
                            if (incidenceMatrix[vertexInLevel, j] == markerVertex)
                            {
                                for (int k = 0; k < incidenceMatrixRow; k++)
                                {
                                    if (incidenceMatrix[k, j] == markerArc)
                                    {
                                        vertexByLevel.Last().Add(k);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (var vertexInLevel in vertexByLevel[vertexByLevel.Count - 2])
                {
                    for (int i = 0; i < incidenceMatrixColumn; i++)
                    {
                        incidenceMatrix[vertexInLevel, i] = 5;
                    }
                }
            }
            vertexByLevel.RemoveAt(vertexByLevel.Count - 1);
            IEnumerable<int> attainableList = new List<int>();

            foreach (var vertex in vertexByLevel)
            {
                attainableList = attainableList.Union(vertex);
            }

            return attainableList.ToList();
        }

        public static DecomposedGraph GetTopologicalDecompositionGraph(int[,] incidenceMatrix)
        {
            int incidenceMatrixRow = incidenceMatrix.GetUpperBound(0) + 1;
            int incidenceMatrixColumn = incidenceMatrix.Length / incidenceMatrixRow;

            int[,] incidenceMatrixCopy = incidenceMatrix.Clone() as int[,];

            DecomposedGraph decomposedGraph = new DecomposedGraph();
            decomposedGraph.IncidenceMatrix = incidenceMatrix.Clone() as int[,];

            //Выделение подграфов
            List<List<int>> attainableList = new List<List<int>>();
            List<List<int>> counterAttainableList = new List<List<int>>();
            IEnumerable<int> intersectEnumerable = new List<int>();
            List<List<int>> intersectList = new List<List<int>>();
            int k = 0;
            while (true)
            {
                attainableList.Add(new List<int>(GetAttainableList(incidenceMatrix.Clone() as int[,], false)));
                counterAttainableList.Add(new List<int>(GetAttainableList(incidenceMatrix.Clone() as int[,], true)));
                intersectEnumerable = (attainableList[k].Intersect(counterAttainableList[k]));
                intersectList.Add(intersectEnumerable.ToList());

                foreach (var numVetrex in intersectList[k])
                {
                    for (int j = 0; j < incidenceMatrixColumn; j++)
                    {
                        incidenceMatrix[numVetrex, j] = 5;
                    }
                }
                k++;

                if (intersectList.Last().Count == 0) break;
            }
            intersectList.RemoveAt(k - 1);

            //Выделение дуг, относящихся к подсистемам
            List<int> busyArcs = new List<int>();
            List<int> arcsTemp = new List<int>();
            int counterSubgraph = 0;
            foreach (var listVertex in intersectList)
            {
                foreach (var vertex in listVertex)
                {
                    for (int i = 0; i < incidenceMatrixColumn; i++)
                    {
                        if (incidenceMatrixCopy[vertex, i] == 1)
                        {
                            for (int j = 0; j < incidenceMatrixRow; j++)
                            {
                                if (incidenceMatrixCopy[j, i] == -1 &&
                                    listVertex.Contains(j))
                                {
                                    arcsTemp.Add(i);
                                    busyArcs.Add(i);
                                    break;
                                }
                            }
                        }
                    }
                }
                Subgraph subgraph = new Subgraph();
                subgraph.Vertex = new List<int>(listVertex);
                subgraph.Arc = new List<int>(arcsTemp);
                subgraph.NumberSubgraph = counterSubgraph;
                decomposedGraph.Subgraphs.Add(subgraph);
                counterSubgraph++;
                arcsTemp.Clear();
            }

            //Построение множества левых инциденций
            List<int> listLeftIncidentsTemp = new List<int>();
            int inVertexTemp = -1; //Входит в вершину
            int outVertexTemp = -1; //Исходит из вершины
            for (int i = 0; i < incidenceMatrixColumn; i++)
            {
                if (!busyArcs.Contains(i))
                {
                    for (int j = 0; j < incidenceMatrixRow; j++)
                    {
                        if (incidenceMatrixCopy[j, i] == -1)
                        {
                            inVertexTemp = j;
                        }
                        else if (incidenceMatrixCopy[j, i] == 1)
                        {
                            outVertexTemp = j;
                        }
                    }

                    //Добавление входящих вершин в подсистему
                    foreach (var subgraphOne in decomposedGraph.Subgraphs)
                    {
                        if (subgraphOne.Vertex.Contains(inVertexTemp))
                        {
                            foreach (var subgraphTwo in decomposedGraph.Subgraphs)
                            {
                                if (subgraphTwo.Vertex.Contains(outVertexTemp) &&
                                    !subgraphOne.ListLeftIncidents.Contains(subgraphTwo.NumberSubgraph))
                                {
                                    subgraphOne.ListLeftIncidents.Add(subgraphTwo.NumberSubgraph);
                                }
                            }
                        }
                    }
                }
            }

            return decomposedGraph;
        }
    }
}
