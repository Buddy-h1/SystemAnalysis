using IncidenceMatrixConverter;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static HierarchicalLevelsIncidenceMatrix.HierarchicalLevelsIncidenceMatrix;

namespace HierarchicalLevelsIncidenceMatrix
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
            countVertexNumericUpDown.Value = 7;
            countArcNumericUpDown.Value = 10;

            inputMatrixDataGridView.ColumnCount = 10;
            inputMatrixDataGridView.RowCount = 7;

            int[,] matrix = {
            { 1, -1, 0, 0, 0, 0, 0, 0, 0, 0},
            { -1, 0, 0, 0, -1, 1, -1, 0, 0, 0},
            { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
            { 0, 0, 0, 0, 0, 0, 0, -1, 1, -1},
            { 0, 0, 0, -1, 1, 0, 0, 0, 0, 1},
            { 0, 0, 0, 0, 0, -1, 0, 0, -1, 0},
            { 0, 0, -1, 0, 0, 0, 1, 1, 0, 0}
            };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    inputMatrixDataGridView[j, i].Value = matrix[i, j];
                }
            }
            UpdateHeaderDataGridView(inputMatrixDataGridView);
        }

        private void searchHierarchicalLevelsButton_Click(object sender, EventArgs e)
        {
            try
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

                HierarchicalLevelsIncMatrix hierarchicalLevelsIncMatrix = HierarchicalLevelsIncidenceMatrix.SearchHierarchicalLevels(incidenceMatrix, outputMatrixDataGridView);

                //Вывод иерархических уровней
                hierarchicalLevelsDataGridView.ColumnCount = 2;
                hierarchicalLevelsDataGridView.RowCount = hierarchicalLevelsIncMatrix.listHierarchicalLevels.Count;
                hierarchicalLevelsDataGridView.Columns[0].HeaderText = "Уровень";
                hierarchicalLevelsDataGridView.Columns[1].HeaderText = "Вершина(ы)";
                for (int i = 0; i < hierarchicalLevelsIncMatrix.listHierarchicalLevels.Count; i++)
                {
                    hierarchicalLevelsDataGridView[0, i].Value = hierarchicalLevelsIncMatrix.listHierarchicalLevels[i].Level;
                    string str = "";
                    foreach(var vertex in hierarchicalLevelsIncMatrix.listHierarchicalLevels[i].Vertex)
                    {
                        str += (vertex.OldNumVertex + 1).ToString() + ", ";
                    }
                    str = str.Remove(str.Length - 2);
                    hierarchicalLevelsDataGridView[1, i].Value = str;
                }

                //Вывод новой матрицы инциденций
                List<int> oldsVertex = new List<int>();
                for (int i = 0; i < hierarchicalLevelsIncMatrix.listHierarchicalLevels.Count; i++)
                {
                    foreach (var vertex in hierarchicalLevelsIncMatrix.listHierarchicalLevels[i].Vertex)
                    {
                        oldsVertex.Add(vertex.OldNumVertex + 1);
                    }
                }

                outputMatrixDataGridView.RowCount = inputMatrixDataGridView.RowCount;
                outputMatrixDataGridView.ColumnCount = inputMatrixDataGridView.ColumnCount;
                for (int i = 0; i < outputMatrixDataGridView.Rows.Count; i++)
                {
                    outputMatrixDataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString() + $"({oldsVertex[i]})"; ;
                }

                for (int i = 0; i < outputMatrixDataGridView.Columns.Count; i++)
                {
                    outputMatrixDataGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
                }

                for (int i = 0; i < outputMatrixDataGridView.RowCount; i++)
                {
                    for (int j = 0; j < outputMatrixDataGridView.ColumnCount; j++)
                    {
                        outputMatrixDataGridView[j, i].Value = hierarchicalLevelsIncMatrix.IncidenceMatrix[i, j];
                    }
                }

                //Вывод множества левых инциденций
                List<List<int>> listInputArcs;
                listInputArcs = ConvertIncidenceMatrix.ConvertToListLeftIncidents(hierarchicalLevelsIncMatrix.IncidenceMatrix, false);

                //Вывод множества левых инциденций
                leftIncidentsTextBox.Text = "";
                string InputArcsLine = "";
                for (int i = 0; i < listInputArcs.Count; i++)
                {
                    for (int j = 0; j < listInputArcs[i].Count; j++)
                    {
                        if (j != listInputArcs[i].Count - 1)
                        {
                            InputArcsLine += listInputArcs[i][j].ToString() + ", ";
                        }
                        else
                        {
                            InputArcsLine += listInputArcs[i][j].ToString();
                        }
                    }
                    leftIncidentsTextBox.Text += $"G-({i + 1}) = {{ {InputArcsLine} }};" + Environment.NewLine;
                    InputArcsLine = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
