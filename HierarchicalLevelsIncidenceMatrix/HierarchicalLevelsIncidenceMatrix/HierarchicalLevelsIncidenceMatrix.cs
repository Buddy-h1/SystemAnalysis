using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HierarchicalLevelsIncidenceMatrix
{
    static class HierarchicalLevelsIncidenceMatrix
    {
        public class OldNewVertex
        {
            public OldNewVertex (int oldNumVertex, int newNumVertex)
            {
                OldNumVertex = oldNumVertex;
                NewNumVertex = newNumVertex;
            }

            public int OldNumVertex { get; set; }
            public int NewNumVertex { get; set; }
        }

        public class HierarchicalLevels
        {
            public HierarchicalLevels()
            {
                Vertex = new List<OldNewVertex>();
            }

            public List<OldNewVertex> Vertex { get; set; }
            public int Level { get; set; }
        }

        public class HierarchicalLevelsIncMatrix
        {
            public HierarchicalLevelsIncMatrix()
            {
                listHierarchicalLevels = new List<HierarchicalLevels>();
                IncidenceMatrix = new int[1, 1];
            }

            public List<HierarchicalLevels> listHierarchicalLevels { get; set; }
            public int[,] IncidenceMatrix { get; set; }
        }

        public static HierarchicalLevelsIncMatrix SearchHierarchicalLevels(int[,] incidenceMatrix, DataGridView dataGridView)
        {
            int[,] incidenceMatrixCopy = new int[incidenceMatrix.GetLength(0), incidenceMatrix.GetLength(1)];
            Array.Copy(incidenceMatrix, incidenceMatrixCopy, incidenceMatrix.Length);

            //Начальная матрица инцидентности
            int incidenceMatrixRow = incidenceMatrix.GetUpperBound(0) + 1;
            int incidenceMatrixColumn = incidenceMatrix.Length / incidenceMatrixRow;

            List<HierarchicalLevels> hierarchicalLevels = new List<HierarchicalLevels>();
            
            int counterNewVertex = -1;
            int counterLevels = -1;
            while (true)
            {
                List<List<int>> listNumbersOutputArcs = new List<List<int>>();
                List<int> numbersOutputArcs = new List<int>();
                List<int> numberRestVertex = new List<int>();
                counterLevels++;
                hierarchicalLevels.Add(new HierarchicalLevels());
                hierarchicalLevels.LastOrDefault().Level = counterLevels;

                //Полный проход по матрице с вычеркиванием строк и
                //выделением номеров столбцов, которые необходимо вычеркнуть
                for (int i = 0; i < incidenceMatrixRow; i++)
                {
                    for (int j = 0; j < incidenceMatrixColumn; j++)
                    {
                        if (incidenceMatrix[i, j] == -1)
                        {
                            numbersOutputArcs.Clear();
                            break;
                        }
                        else if (incidenceMatrix[i, j] == 1) numbersOutputArcs.Add(j);
                        else if (incidenceMatrix[i, j] == 5) continue;
                    }

                    if (numbersOutputArcs.Count > 0)
                    {
                        //Вычеркивание строки
                        for (int j = 0; j < incidenceMatrixColumn; j++)
                            incidenceMatrix[i, j] = 5;
                        listNumbersOutputArcs.Add(new List<int>(numbersOutputArcs));
                        numbersOutputArcs.Clear();
                        numberRestVertex.Add(i);
                    }
                }

                //Проверка на то, что все строки вычеркнуты
                if (listNumbersOutputArcs.Count == 0) break;

                //Вычеркивание столбцов
                for (int i = 0; i < listNumbersOutputArcs.Count; i++)
                {
                    foreach (var numArc in listNumbersOutputArcs[i])
                    {
                        for (int j = 0; j < incidenceMatrixRow; j++)
                        {
                            incidenceMatrix[j, numArc] = 5;
                        }
                    }
                }

                foreach (var numVertex in numberRestVertex)
                {
                    counterNewVertex++;
                    hierarchicalLevels.LastOrDefault().Vertex.Add(new OldNewVertex(numVertex, counterNewVertex));
                }
            }

            //Добавление оставшихся вершин
            List<int> allOldVertex = new List<int>();
            for (int i = 0; i < incidenceMatrixRow; i++)
            {
                allOldVertex.Add(i);
            }
            List<int> addedVertex = new List<int>();
            for (int i = 0; i < hierarchicalLevels.Count; i++)
            {
                foreach (var vertex in hierarchicalLevels[i].Vertex)
                {
                    addedVertex.Add(vertex.OldNumVertex);
                }
            }
            var restVertex = allOldVertex.Where(p => addedVertex.All(p2 => p2 != p)).ToList();
            hierarchicalLevels.LastOrDefault().Level = counterLevels;
            foreach (var rVertex in restVertex)
            {
                counterNewVertex++;
                hierarchicalLevels.LastOrDefault().Vertex.Add(new OldNewVertex(rVertex, counterNewVertex));
            }

            for (int i = 0; i < hierarchicalLevels.Count; i++)
            {
                foreach (var vertex in hierarchicalLevels[i].Vertex)
                {
                    Array.Copy(incidenceMatrixCopy,
                               incidenceMatrixColumn * vertex.OldNumVertex,
                               incidenceMatrix,
                               incidenceMatrixColumn * vertex.NewNumVertex,
                               incidenceMatrixColumn
                               );
                }
            }

            HierarchicalLevelsIncMatrix hierarchicalLevelsIncMatrix = new HierarchicalLevelsIncMatrix();
            hierarchicalLevelsIncMatrix.IncidenceMatrix = incidenceMatrix;
            hierarchicalLevelsIncMatrix.listHierarchicalLevels = hierarchicalLevels;
            return hierarchicalLevelsIncMatrix;
        }

    }
}
