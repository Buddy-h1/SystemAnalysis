using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphStructureConnectivity
{
    static class MatrixStructuralConnectivity
    {
        public static int CountPaths(ref int[,] incidenceMatrix, int start, int end)
        {
            if (start == end) return 0;

            bool[] visited = new bool[incidenceMatrix.GetLength(0)];
            int count = 0;

            DFS(ref incidenceMatrix, start, end, visited, ref count);

            return count;
        }

        public static void DFS(ref int[,] incidenceMatrix, int curr, int end, bool[] visited, ref int count)
        {
            visited[curr] = true;

            if (curr == end)
            {
                count++;
                visited[curr] = false;
                return;
            }

            for (int i = 0; i < incidenceMatrix.GetLength(1); i++)
            {
                if (incidenceMatrix[curr, i] == 1)
                {
                    int next = -1;

                    for (int j = 0; j < incidenceMatrix.GetLength(0); j++)
                    {
                        if (incidenceMatrix[j, i] == -1)
                        {
                            next = j;
                            break;
                        }
                    }

                    if (!visited[next])
                    {
                        DFS(ref incidenceMatrix, next, end, visited, ref count);
                    }
                }
            }

            visited[curr] = false;
        }

        public static int[,] GetSumConnectMatrix(int[,] incidenceMatrix)
        {
            int incidenceMatrixRow = incidenceMatrix.GetUpperBound(0) + 1;
            int[,] sumConnectMatrix = new int[incidenceMatrixRow, incidenceMatrixRow];

            for (int i = 0; i < incidenceMatrixRow; i++)
            {
                for (int j = 0; j < incidenceMatrixRow; j++)
                {
                    sumConnectMatrix[i, j] = CountPaths(ref incidenceMatrix, i, j);
                }
            }

            return sumConnectMatrix;
        }
    }
}
