using System.Collections.Generic;
using System.Linq;

namespace IncidenceMatrixConverter
{
    static class ConvertIncidenceMatrix
    {
        public static int[,] ConvertToAdjMatrix(int[,] incidenceMatrix, bool considerDoubleArcs = true)
        {
            //Матрица инцидентности
            int incidenceMatrixRow = incidenceMatrix.GetUpperBound(0) + 1;
            int incidenceMatrixColumn = incidenceMatrix.Length / incidenceMatrixRow;

            //Матрица смежности
            int[,] adjacencyMatrix = new int[incidenceMatrixRow, incidenceMatrixRow];
            int adjacencyMatrixRow = adjacencyMatrix.GetUpperBound(0) + 1;
            int adjacencyMatrixColumn = adjacencyMatrix.Length / adjacencyMatrixRow;
            for (int i = 0; i < adjacencyMatrixRow; i++)
            {
                for (int j = 0; j < adjacencyMatrixColumn; j++)
                {
                    adjacencyMatrix[j, i] = 0;
                }
            }

            //Алгоритм преобразования
            for (int i = 0; i < incidenceMatrixColumn; i++)
            {
                for (int j = 0; j < incidenceMatrixRow; j++)
                {
                    if (incidenceMatrix[j, i] == 1)
                    {
                        bool flagPair = false;
                        bool flagMinusOne = false;
                        for (int k = 0; k < incidenceMatrixRow; k++)
                        {
                            if (j == k) continue;
                            if (incidenceMatrix[k, i] == 1)
                            {
                                adjacencyMatrix[k, j] += 1;
                                flagPair = true;
                                break;
                            }
                            else if (incidenceMatrix[k, i] == -1) flagMinusOne = true;
                        }
                        if (!flagPair && !flagMinusOne)
                        {
                            adjacencyMatrix[j, j] += 1;
                        }
                    }
                    else if (incidenceMatrix[j, i] == -1)
                    {
                        bool flagPair = false;
                        for (int k = 0; k < incidenceMatrixRow; k++)
                        {
                            if (incidenceMatrix[k, i] == 1)
                            {
                                adjacencyMatrix[j, k] += 1;
                                flagPair = true;
                                break;
                            }
                        }
                        if (flagPair == false)
                        {
                            adjacencyMatrix[j, j] += 1;
                        }
                    }
                }
            }

            if (considerDoubleArcs) return adjacencyMatrix;
            else
            {
                for (int i = 0; i < adjacencyMatrixRow; i++)
                {
                    for (int j = 0; j < adjacencyMatrixColumn; j++)
                    {
                        if (adjacencyMatrix[j, i] > 1)
                            adjacencyMatrix[j, i] = 1;
                    }
                }
                return adjacencyMatrix;
            }
        }

        public static List<List<int>> ConvertToListLeftIncidents(int[,] incidenceMatrix, bool considerDoubleArcs = true)
        {
            //Матрица инцидентности
            int incidenceMatrixRow = incidenceMatrix.GetUpperBound(0) + 1;
            int incidenceMatrixColumn = incidenceMatrix.Length / incidenceMatrixRow;

            //Лист множества левых инциденций
            List<List<int>> listInputArcs = new List<List<int>>();
            for (int i = 0; i < incidenceMatrixRow; i++)
            {
                listInputArcs.Add(new List<int>());
            }

            //Алгоритм преобразования
            for (int i = 0; i < incidenceMatrixColumn; i++)
            {
                for (int j = 0; j < incidenceMatrixRow; j++)
                {
                    if (incidenceMatrix[j, i] == 1)
                    {
                        bool flagPair = false;
                        bool flagMinusOne = false;
                        for (int k = 0; k < incidenceMatrixRow; k++)
                        {
                            if (j == k) continue;
                            if (incidenceMatrix[k, i] == 1)
                            {
                                listInputArcs[j].Add(k + 1);
                                flagPair = true;
                                break;
                            }
                            else if (incidenceMatrix[k, i] == -1) flagMinusOne = true;
                        }
                        if (!flagPair && !flagMinusOne)
                        {
                            listInputArcs[j].Add(j + 1);
                        }
                    }
                    else if (incidenceMatrix[j, i] == -1)
                    {
                        bool flagPair = false;
                        for (int k = 0; k < incidenceMatrixRow; k++)
                        {
                            if (incidenceMatrix[k, i] == 1)
                            {
                                listInputArcs[j].Add(k + 1);
                                flagPair = true;
                                break;
                            }
                        }
                        if (flagPair == false)
                        {
                            listInputArcs[j].Add(j + 1);
                        }
                    }
                }
            }

            for (int i = 0; i < listInputArcs.Count; i++)
            {
                listInputArcs[i].Sort();
            }

            if (considerDoubleArcs) return listInputArcs;
            else
            {
                for (int i = 0; i < listInputArcs.Count; i++)
                {
                    listInputArcs[i] = listInputArcs[i].Distinct().ToList();
                }
                return listInputArcs;
            }
        }
    }
}
