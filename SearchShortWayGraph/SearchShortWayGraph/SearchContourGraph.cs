using System.Collections.Generic;

namespace SearchShortWayGraph
{
    public static class SearchContourGraph
    {
        public static string FindCycleInAdjacencyMatrix(int[,] adjacencyMatrix)
        {
            int n = adjacencyMatrix.GetLength(0); // количество вершин в графе
            bool[] visited = new bool[n]; // массив для отметки посещенных вершин
            Stack<int> stack = new Stack<int>(); // стек для хранения текущего пути

            // вспомогательная функция для поиска контура
            bool DFS(int vertex, int parent, out int cycleStart)
            {
                visited[vertex] = true;
                stack.Push(vertex);

                for (int i = 0; i < n; i++)
                {
                    if (i == parent) // не рассматриваем ребро к предку
                        continue;

                    if (adjacencyMatrix[vertex, i] == 1)
                    {
                        if (visited[i])
                        {
                            if (stack.Contains(i)) // нашли контур
                            {
                                cycleStart = i;
                                return true;
                            }
                        }
                        else
                        {
                            if (DFS(i, vertex, out cycleStart))
                                return true;
                        }
                    }
                }

                // не нашли контур, удаляем вершину из стека и возвращаемся к предыдущей вершине
                stack.Pop();
                cycleStart = -1;
                return false;
            }

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    int cycleStart;
                    if (DFS(i, -1, out cycleStart))
                    {
                        // собираем контур из стека
                        string result = $"{cycleStart}";
                        int vertex = stack.Pop();
                        while (vertex != cycleStart)
                        {
                            result = $"{vertex} -> {result}";
                            vertex = stack.Pop();
                        }
                        result = $"{cycleStart} -> {result}";
                        return result;
                    }
                }
            }
            return ""; // контур не найден
        }
    }
}
