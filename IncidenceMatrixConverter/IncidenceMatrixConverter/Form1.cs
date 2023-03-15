using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IncidenceMatrixConverter
{
    public partial class MainForm : MaterialForm
    {
        private int startCountColumn = 5;
        private int startCountRow = 5;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            conversionTypeComboBox.SelectedIndex = 0;
            inputMatrixDataGridView.ColumnCount = startCountColumn;
            inputMatrixDataGridView.RowCount = startCountRow;
        }

        private void countArcNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            inputMatrixDataGridView.RowCount = Convert.ToInt32(countVertexNumericUpDown.Value);
        }

        private void countVertexNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            inputMatrixDataGridView.ColumnCount = Convert.ToInt32(countArcNumericUpDown.Value);
        }

        private void conversionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = conversionTypeComboBox.SelectedItem.ToString();
            if (selectedState == "Матрица смежности")
            {
                outputMatrixDataGridView.Visible = true;
                outputTextBox.Visible = false;
            }
            else if (selectedState == "Множество левых инциденций")
            {
                outputMatrixDataGridView.Visible = false;
                outputTextBox.Visible = true;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedState = conversionTypeComboBox.SelectedItem.ToString();
                bool considerDoubleArcs = considerDoubleArcsCheckBox.Checked;

                //Матрица инциденций
                int[,] incidenceMatrix = new int[inputMatrixDataGridView.RowCount, inputMatrixDataGridView.ColumnCount];
                for (int i = 0; i < inputMatrixDataGridView.RowCount; i++)
                {
                    for (int j = 0; j < inputMatrixDataGridView.ColumnCount; j++)
                    {
                        incidenceMatrix[i, j] = Convert.ToInt32(inputMatrixDataGridView[j, i].Value);
                    }
                }

                if (selectedState == "Матрица смежности")
                {
                    int[,] adjacencyMatrix;
                    if (considerDoubleArcs) adjacencyMatrix = ConvertIncidenceMatrix.ConvertToAdjMatrix(incidenceMatrix);
                    else adjacencyMatrix = ConvertIncidenceMatrix.ConvertToAdjMatrix(incidenceMatrix, false);

                    //Вывод матрицы смежности
                    int adjacencyMatrixRow = adjacencyMatrix.GetUpperBound(0) + 1;
                    int adjacencyMatrixColumn = adjacencyMatrix.Length / adjacencyMatrixRow;
                    outputMatrixDataGridView.RowCount = adjacencyMatrixRow;
                    outputMatrixDataGridView.ColumnCount = adjacencyMatrixColumn;
                    for (int i = 0; i < adjacencyMatrixRow; i++)
                    {
                        for (int j = 0; j < adjacencyMatrixColumn; j++)
                        {
                            outputMatrixDataGridView[j, i].Value = adjacencyMatrix[j, i];
                        }
                    }
                }
                else if (selectedState == "Множество левых инциденций")
                {
                    List<List<int>> listInputArcs;
                    if (considerDoubleArcs) listInputArcs = ConvertIncidenceMatrix.ConvertToListLeftIncidents(incidenceMatrix);
                    else listInputArcs = ConvertIncidenceMatrix.ConvertToListLeftIncidents(incidenceMatrix, false);

                    //Вывод множества левых инциденций
                    outputTextBox.Text = "";
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
                        outputTextBox.Text += $"G({i + 1}) = {{ {InputArcsLine} }};" + Environment.NewLine;
                        InputArcsLine = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < inputMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < inputMatrixDataGridView.ColumnCount; j++)
                {
                    inputMatrixDataGridView[j, i].Value = null;
                }
            }
        }

        private void orientedGraphButton_Click(object sender, EventArgs e)
        {
            countVertexNumericUpDown.Value = 5;
            countArcNumericUpDown.Value = 7;

            inputMatrixDataGridView.ColumnCount = 7;
            inputMatrixDataGridView.RowCount = 5;

            int[,] matrix = {
            { 1, 1, 0, 0, -1, -1, 0 },
            { -1, -1, 1, 0, 1, 0, 0 },
            { 0, 0, -1, 1, 0, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, -1 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    inputMatrixDataGridView[j, i].Value = matrix[i, j];
                }
            }
        }

        private void unorientedGraphButton_Click(object sender, EventArgs e)
        {
            countVertexNumericUpDown.Value = 5;
            countArcNumericUpDown.Value = 7;

            inputMatrixDataGridView.ColumnCount = 7;
            inputMatrixDataGridView.RowCount = 5;

            int[,] matrix = {
            { 1, 1, 0, 0, 1, 1, 0 },
            { 1, 1, 1, 0, 1, 0, 0 },
            { 0, 0, 1, 1, 0, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    inputMatrixDataGridView[j, i].Value = matrix[i, j];
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }
    }
}
