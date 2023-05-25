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

namespace GraphStructureConnectivity
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
            countVertexNumericUpDown.Value = 5;
            countArcNumericUpDown.Value = 5;

            inputMatrixDataGridView.ColumnCount = 5;
            inputMatrixDataGridView.RowCount = 5;

            int[,] matrix = {
            { 1, -1, 0, 0, 0 },
            { -1, 0, -1, 1, 0 },
            { 0, 1, 1, 0, -1 },
            { 0, 0, 0, -1, 0 },
            { 0, 0, 0, 0, 1 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    inputMatrixDataGridView[j, i].Value = matrix[i, j];
                }
            }
            UpdateHeaderDataGridView(inputMatrixDataGridView);


            //countVertexNumericUpDown.Value = 10;
            //countArcNumericUpDown.Value = 18;

            //inputMatrixDataGridView.ColumnCount = 18;
            //inputMatrixDataGridView.RowCount = 10;

            //int[,] matrix = {
            //{ 1, 1, 1, -1, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ -1, 0, 0, 1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 1, -1, 0, 0, 0, 0 },
            //{ 0, -1, 0, 0, 0, -1, 1, -1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, -1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 1, -1, 0, 0, -1 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 1, 1, -1, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 1 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, -1, 1, 0 }
            //};

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 18; j++)
            //    {
            //        inputMatrixDataGridView[j, i].Value = matrix[i, j];
            //    }
            //}
            //UpdateHeaderDataGridView(inputMatrixDataGridView);
        }

        private void getMatrixStructuralConnectivity_Click(object sender, EventArgs e)
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

            MatrixStructuralConnectivity.GetSumConnectMatrix(incidenceMatrix);

            int[,] sumConnectMatrix = MatrixStructuralConnectivity.GetSumConnectMatrix(incidenceMatrix);
            int sumConnectMatrixRow = sumConnectMatrix.GetUpperBound(0) + 1;
            sumConnectMatrixDataGridView.ColumnCount = sumConnectMatrixRow;
            sumConnectMatrixDataGridView.RowCount = sumConnectMatrixRow;

            for (int i = 0; i < sumConnectMatrixRow; i++)
            {
                for (int j = 0; j < sumConnectMatrixRow; j++)
                {
                    sumConnectMatrixDataGridView[i, j].Value = sumConnectMatrix[j, i];
                }
            }
            UpdateHeaderDataGridView(sumConnectMatrixDataGridView);

            int[,] connectMatrix = new int[sumConnectMatrix.GetLength(0), sumConnectMatrix.GetLength(1)];
            Array.Copy(sumConnectMatrix, connectMatrix, sumConnectMatrix.Length);
            int connectMatrixRow = connectMatrix.GetUpperBound(0) + 1;
            connectMatrixDataGridView.ColumnCount = connectMatrixRow;
            connectMatrixDataGridView.RowCount = connectMatrixRow;

            for (int i = 0; i < connectMatrixRow; i++)
            {
                for (int j = 0; j < connectMatrixRow; j++)
                {
                    if (connectMatrix[i, j] > 0)
                    {
                        connectMatrix[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < connectMatrixRow; i++)
            {
                for (int j = 0; j < connectMatrixRow; j++)
                {
                    connectMatrixDataGridView[i, j].Value = connectMatrix[j, i];
                }
            }
            UpdateHeaderDataGridView(connectMatrixDataGridView);
        }
    }
}
