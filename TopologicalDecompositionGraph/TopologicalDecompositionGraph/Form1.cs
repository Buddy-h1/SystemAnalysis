using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TopologicalDecompositionGraph.TopologicalDecompositionGraph;

namespace TopologicalDecompositionGraph
{
    public partial class MainForm : MaterialForm
    {
        private int startCountColumn = 5;
        private int startCountRow = 5;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateHeaderDataGridView(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            inputMatrixDataGridView.ColumnCount = startCountColumn;
            inputMatrixDataGridView.RowCount = startCountRow;
            UpdateHeaderDataGridView(inputMatrixDataGridView);
        }

        private void countArcNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            inputMatrixDataGridView.ColumnCount = Convert.ToInt32(countArcNumericUpDown.Value);
            UpdateHeaderDataGridView(inputMatrixDataGridView);
        }

        private void countVertexNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            inputMatrixDataGridView.RowCount = Convert.ToInt32(countVertexNumericUpDown.Value);
            UpdateHeaderDataGridView(inputMatrixDataGridView);
        }

        private void orientedGraphButton_Click(object sender, EventArgs e)
        {
            countVertexNumericUpDown.Value = 10;
            countArcNumericUpDown.Value = 18;

            inputMatrixDataGridView.ColumnCount = 18;
            inputMatrixDataGridView.RowCount = 10;

            int[,] matrix = {
            { 1, 1, 1, -1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { -1, 0, 0, 1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 1, -1, 0, 0, 0, 0 },
            { 0, -1, 0, 0, 0, -1, 1, -1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, -1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 1, -1, 0, 0, -1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 1, 1, -1, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, -1, 1, 0 }
            };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    inputMatrixDataGridView[j, i].Value = matrix[i, j];
                }
            }
            UpdateHeaderDataGridView(inputMatrixDataGridView);

            //countVertexNumericUpDown.Value = 10;
            //countArcNumericUpDown.Value = 14;

            //inputMatrixDataGridView.ColumnCount = 14;
            //inputMatrixDataGridView.RowCount = 10;

            //int[,] matrix = {
            //{ 1, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 0 },
            //{ -1, -1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            //{ 0, 1, -1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
            //{ 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            //{ 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 1, -1, 0, 0, 0, 0, 0, 0, 1, 0 },
            //{ 0, 0, 0, 0, 0, 1, 1, 0, 0, -1, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, -1, 1, 0, 0, 0, -1, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, -1, 1, 0, 0, 0, 0, -1 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, -1, 1 }
            //};

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 14; j++)
            //    {
            //        inputMatrixDataGridView[j, i].Value = matrix[i, j];
            //    }
            //}
            //UpdateHeaderDataGridView(inputMatrixDataGridView);
        }

        private void startTopologicalDecompositionGraph_Click(object sender, EventArgs e)
        {
            //Матрица инциденций
            int[,] incidenceMatrix = new int[inputMatrixDataGridView.RowCount, inputMatrixDataGridView.ColumnCount];
            for (int i = 0; i < inputMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < inputMatrixDataGridView.ColumnCount; j++)
                {
                    incidenceMatrix[i, j] = Convert.ToInt32(inputMatrixDataGridView[j, i].Value);
                }
            }

            DecomposedGraph decomposedGraph = GetTopologicalDecompositionGraph(incidenceMatrix);

            //Вывод подсистем графа
            SubgraphsDataGridView.ColumnCount = 3;
            SubgraphsDataGridView.RowCount = decomposedGraph.Subgraphs.Count;
            SubgraphsDataGridView.Columns[0].HeaderText = "Подсистема";
            SubgraphsDataGridView.Columns[1].HeaderText = "Вершина(ы)";
            SubgraphsDataGridView.Columns[2].HeaderText = "Дуга(и)";
            for (int i = 0; i < decomposedGraph.Subgraphs.Count; i++)
            {
                SubgraphsDataGridView[0, i].Value = "G" + (decomposedGraph.Subgraphs[i].NumberSubgraph + 1).ToString();
                string str = "";
                foreach (var vertex in decomposedGraph.Subgraphs[i].Vertex)
                {
                    str += (vertex + 1).ToString() + ", ";
                }
                if (str != "") str = str.Remove(str.Length - 2);
                SubgraphsDataGridView[1, i].Value = str;

                str = "";
                foreach (var arc in decomposedGraph.Subgraphs[i].Arc)
                {
                    str += (arc + 1).ToString() + ", ";
                }
                if (str != "") str = str.Remove(str.Length - 2);
                SubgraphsDataGridView[2, i].Value = str;
            }

            //Вывод множества левых инциденций
            leftIncidentsTextBox.Text = "";
            for (int i = 0; i < decomposedGraph.Subgraphs.Count; i++)
            {
                string inputArcsLine = "";
                decomposedGraph.Subgraphs[i].ListLeftIncidents.Sort();
                foreach (var vertex in decomposedGraph.Subgraphs[i].ListLeftIncidents)
                {
                    inputArcsLine += (vertex + 1).ToString() + ", ";
                }
                if (inputArcsLine != "") inputArcsLine = inputArcsLine.Remove(inputArcsLine.Length - 2);

                leftIncidentsTextBox.Text += $"G-({decomposedGraph.Subgraphs[i].NumberSubgraph + 1}) = {{ {inputArcsLine} }};" + Environment.NewLine;
                inputArcsLine = "";
            }

        }
    }
}
