using System;

namespace SearchShortWayGraph
{
    public static class ShortWayGraph
    {
        public static int GetShortWayDistance(ref int[,] distanceMatrix, int current, int end, int distance = 0)
        {
            if (current == end)
            {
                return distance;
            }

            int sizeDistanceMatrix = distanceMatrix.GetUpperBound(0) + 1;
            int shortestDistance = int.MaxValue;

            for (int i = 0; i < sizeDistanceMatrix; i++)
            {
                if (distanceMatrix[current, i] != 0)
                {
                    int newDistance = GetShortWayDistance(ref distanceMatrix, i, end, distance + distanceMatrix[current, i]);
                    if (newDistance < shortestDistance && newDistance != 0)
                    {
                        shortestDistance = newDistance;
                    }
                }
            }

            return shortestDistance == int.MaxValue ? 0 : shortestDistance;
        }

        public static int [,] GetShortWayMatrix(int[,] distanceMatrix)
        {
            int shortWayRow = distanceMatrix.GetUpperBound(0) + 1;
            int shortWayColumn = distanceMatrix.Length / shortWayRow;
            int[,] shortWayMatrix = new int[shortWayRow, shortWayColumn];

            for (int i = 0; i < shortWayRow; i++)
            {
                for (int j = 0; j < shortWayColumn; j++)
                {
                    if (i == j) continue;
                    else shortWayMatrix[i, j] = GetShortWayDistance(ref distanceMatrix, i, j);
                }
            }

            return shortWayMatrix;
        }
    }
}
