using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SearchShortWayGraph
{
    public partial class MainForm : MaterialForm
    {
        private int startCountColumnRow = 5;

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

        public void UpdateReadOnlyDiagonal(DataGridView dataGridView)
        {
            int offset = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView[i, offset].Value = "M";
                dataGridView[i, offset].ReadOnly = true;
                offset++;
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            distanceMatrixDataGridView.ColumnCount = startCountColumnRow;
            distanceMatrixDataGridView.RowCount = startCountColumnRow;
            UpdateHeaderDataGridView(distanceMatrixDataGridView);
            UpdateReadOnlyDiagonal(distanceMatrixDataGridView);
        }
        
        private void countVertexNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            distanceMatrixDataGridView.ColumnCount = Convert.ToInt32(countVertexNumericUpDown.Value);
            distanceMatrixDataGridView.RowCount = Convert.ToInt32(countVertexNumericUpDown.Value);
            UpdateHeaderDataGridView(distanceMatrixDataGridView);
            UpdateReadOnlyDiagonal(distanceMatrixDataGridView);
        }
        private void orientedGraphButton_Click(object sender, EventArgs e)
        {
            countVertexNumericUpDown.Value = 7;

            distanceMatrixDataGridView.ColumnCount = 7;
            distanceMatrixDataGridView.RowCount = 7;

            //Граф с контуром
            //string[,] matrix = {
            //{ "M", "2", "0", "0", "0", "0", "0" },
            //{ "0", "M", "5", "0", "0", "7", "0" },
            //{ "6", "0", "M", "0", "8", "0", "9" },
            //{ "0", "0", "0", "M", "0", "6", "0" },
            //{ "0", "11", "0", "0", "M", "0", "0" },
            //{ "0", "0", "0", "0", "0", "M", "0" },
            //{ "0", "0", "0", "12", "0", "0", "M" }
            //};

            string[,] matrix = {
            { "M", "2", "4", "10", "0", "0", "0" },
            { "0", "M", "0", "11", "5", "0", "0" },
            { "0", "0", "M", "3", "0", "1", "0" },
            { "0", "0", "0", "M", "8", "7", "0" },
            { "0", "0", "0", "0", "M", "0", "6" },
            { "0", "0", "0", "0", "0", "M", "9" },
            { "0", "0", "0", "0", "0", "0", "M" }
            };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    distanceMatrixDataGridView[j, i].Value = matrix[i, j];
                }
            }
            UpdateHeaderDataGridView(distanceMatrixDataGridView);
        }

        private void startGetShortWayMatrix_Click(object sender, EventArgs e)
        {
            //Матрица расстояний
            int[,] distanceMatrix = new int[distanceMatrixDataGridView.RowCount, distanceMatrixDataGridView.ColumnCount];
            for (int i = 0; i < distanceMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < distanceMatrixDataGridView.ColumnCount; j++)
                {
                    if ((string)distanceMatrixDataGridView[i, j].Value == "M")
                    {
                        distanceMatrix[i, j] = 0;
                    }
                    else
                        distanceMatrix[i, j] = Convert.ToInt32(distanceMatrixDataGridView[j, i].Value);
                }
            }

            int[,] adjacencyMatrix = distanceMatrix.Clone() as int[,];
            for (int i = 0; i < distanceMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < distanceMatrixDataGridView.ColumnCount; j++)
                {
                    if (adjacencyMatrix[i, j] != 0) adjacencyMatrix[i, j] = 1;
                }
            }
            string graphContour = SearchContourGraph.FindCycleInAdjacencyMatrix(adjacencyMatrix);
            if (graphContour != "")
            {
                MessageBox.Show("В введенной матрице обнаружен контур. " +
                    "Алгоритм программы не рассчитан на графы с контуром\n\n" +
                    $"Контур: {graphContour}",
                    "Ошибка", MessageBoxButtons.OK);
                return;
            }

                int[,] shortWayMatrix = ShortWayGraph.GetShortWayMatrix(distanceMatrix);
            int shortWayRow = distanceMatrix.GetUpperBound(0) + 1;
            int shortWayColumn = distanceMatrix.Length / shortWayRow;

            shortWayMatrixDataGridView.RowCount = shortWayRow;
            shortWayMatrixDataGridView.ColumnCount = shortWayColumn;
            UpdateHeaderDataGridView(shortWayMatrixDataGridView);
            UpdateReadOnlyDiagonal(shortWayMatrixDataGridView);

            for (int i = 0; i < shortWayRow; i++)
            {
                for (int j = 0; j < shortWayColumn; j++)
                {
                    if (i == j) shortWayMatrixDataGridView[j, i].Value = "M";
                    else shortWayMatrixDataGridView[j, i].Value = shortWayMatrix[i, j];
                }
            }

            for (int i = 0; i < shortWayMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < shortWayMatrixDataGridView.ColumnCount; j++)
                {
                    if (i == j) continue;
                    else shortWayMatrixDataGridView[i, j].ReadOnly = !shortWayMatrixDataGridView[i, j].ReadOnly;
                }
            }
        }

        private void correctionButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shortWayMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < shortWayMatrixDataGridView.ColumnCount; j++)
                {
                    if (i == j) continue;
                    else shortWayMatrixDataGridView[i, j].ReadOnly = !shortWayMatrixDataGridView[i, j].ReadOnly;
                }
            }
        }
    }
}
