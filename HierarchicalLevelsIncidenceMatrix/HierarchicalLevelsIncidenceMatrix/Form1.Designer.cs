namespace HierarchicalLevelsIncidenceMatrix
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.sizeMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.countArcNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countArcLabel = new System.Windows.Forms.Label();
            this.countVertexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countVertex = new System.Windows.Forms.Label();
            this.orientedGraphButton = new System.Windows.Forms.Button();
            this.searchHierarchicalLevelsButton = new System.Windows.Forms.Button();
            this.leftIncidentsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hierarchicalLevelsDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.outputMatrixDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inputMatrixDataGridView)).BeginInit();
            this.sizeMatrixGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countArcNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertexNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hierarchicalLevelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputMatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inputMatrixDataGridView
            // 
            this.inputMatrixDataGridView.AllowUserToAddRows = false;
            this.inputMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.inputMatrixDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.inputMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputMatrixDataGridView.GridColor = System.Drawing.Color.Black;
            this.inputMatrixDataGridView.Location = new System.Drawing.Point(14, 211);
            this.inputMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputMatrixDataGridView.Name = "inputMatrixDataGridView";
            this.inputMatrixDataGridView.RowHeadersWidth = 70;
            this.inputMatrixDataGridView.Size = new System.Drawing.Size(492, 243);
            this.inputMatrixDataGridView.TabIndex = 5;
            // 
            // sizeMatrixGroupBox
            // 
            this.sizeMatrixGroupBox.Controls.Add(this.countArcNumericUpDown);
            this.sizeMatrixGroupBox.Controls.Add(this.countArcLabel);
            this.sizeMatrixGroupBox.Controls.Add(this.countVertexNumericUpDown);
            this.sizeMatrixGroupBox.Controls.Add(this.countVertex);
            this.sizeMatrixGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeMatrixGroupBox.Location = new System.Drawing.Point(14, 85);
            this.sizeMatrixGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sizeMatrixGroupBox.Name = "sizeMatrixGroupBox";
            this.sizeMatrixGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sizeMatrixGroupBox.Size = new System.Drawing.Size(492, 90);
            this.sizeMatrixGroupBox.TabIndex = 6;
            this.sizeMatrixGroupBox.TabStop = false;
            this.sizeMatrixGroupBox.Text = "Размер матрицы";
            // 
            // countArcNumericUpDown
            // 
            this.countArcNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countArcNumericUpDown.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countArcNumericUpDown.Location = new System.Drawing.Point(309, 52);
            this.countArcNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.countArcNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.countArcNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countArcNumericUpDown.Name = "countArcNumericUpDown";
            this.countArcNumericUpDown.Size = new System.Drawing.Size(175, 22);
            this.countArcNumericUpDown.TabIndex = 1;
            this.countArcNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.countArcNumericUpDown.ValueChanged += new System.EventHandler(this.countArcNumericUpDown_ValueChanged);
            // 
            // countArcLabel
            // 
            this.countArcLabel.AutoSize = true;
            this.countArcLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countArcLabel.Location = new System.Drawing.Point(306, 32);
            this.countArcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countArcLabel.Name = "countArcLabel";
            this.countArcLabel.Size = new System.Drawing.Size(169, 15);
            this.countArcLabel.TabIndex = 2;
            this.countArcLabel.Text = "Кол-во ребер/дуг (столбцы)";
            // 
            // countVertexNumericUpDown
            // 
            this.countVertexNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countVertexNumericUpDown.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countVertexNumericUpDown.Location = new System.Drawing.Point(10, 52);
            this.countVertexNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.countVertexNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countVertexNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countVertexNumericUpDown.Name = "countVertexNumericUpDown";
            this.countVertexNumericUpDown.Size = new System.Drawing.Size(175, 22);
            this.countVertexNumericUpDown.TabIndex = 0;
            this.countVertexNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.countVertexNumericUpDown.ValueChanged += new System.EventHandler(this.countVertexNumericUpDown_ValueChanged);
            // 
            // countVertex
            // 
            this.countVertex.AutoSize = true;
            this.countVertex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countVertex.Location = new System.Drawing.Point(7, 32);
            this.countVertex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countVertex.Name = "countVertex";
            this.countVertex.Size = new System.Drawing.Size(144, 15);
            this.countVertex.TabIndex = 0;
            this.countVertex.Text = "Кол-во вершин (строки)";
            // 
            // orientedGraphButton
            // 
            this.orientedGraphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.orientedGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.orientedGraphButton.FlatAppearance.BorderSize = 0;
            this.orientedGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orientedGraphButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orientedGraphButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orientedGraphButton.Location = new System.Drawing.Point(514, 92);
            this.orientedGraphButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orientedGraphButton.Name = "orientedGraphButton";
            this.orientedGraphButton.Size = new System.Drawing.Size(211, 40);
            this.orientedGraphButton.TabIndex = 17;
            this.orientedGraphButton.Text = "Пример (Ор-граф)";
            this.orientedGraphButton.UseVisualStyleBackColor = false;
            this.orientedGraphButton.Click += new System.EventHandler(this.orientedGraphButton_Click);
            // 
            // searchHierarchicalLevelsButton
            // 
            this.searchHierarchicalLevelsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.searchHierarchicalLevelsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.searchHierarchicalLevelsButton.FlatAppearance.BorderSize = 0;
            this.searchHierarchicalLevelsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchHierarchicalLevelsButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchHierarchicalLevelsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchHierarchicalLevelsButton.Location = new System.Drawing.Point(514, 135);
            this.searchHierarchicalLevelsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchHierarchicalLevelsButton.Name = "searchHierarchicalLevelsButton";
            this.searchHierarchicalLevelsButton.Size = new System.Drawing.Size(211, 40);
            this.searchHierarchicalLevelsButton.TabIndex = 18;
            this.searchHierarchicalLevelsButton.Text = "Начать";
            this.searchHierarchicalLevelsButton.UseVisualStyleBackColor = false;
            this.searchHierarchicalLevelsButton.Click += new System.EventHandler(this.searchHierarchicalLevelsButton_Click);
            // 
            // leftIncidentsTextBox
            // 
            this.leftIncidentsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.leftIncidentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftIncidentsTextBox.Location = new System.Drawing.Point(514, 481);
            this.leftIncidentsTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leftIncidentsTextBox.Multiline = true;
            this.leftIncidentsTextBox.Name = "leftIncidentsTextBox";
            this.leftIncidentsTextBox.ReadOnly = true;
            this.leftIncidentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.leftIncidentsTextBox.Size = new System.Drawing.Size(213, 243);
            this.leftIncidentsTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(511, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Иерархические уровни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(511, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Множество левых инциденций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Начальная матрица инцидентности";
            // 
            // hierarchicalLevelsDataGridView
            // 
            this.hierarchicalLevelsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.hierarchicalLevelsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.hierarchicalLevelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hierarchicalLevelsDataGridView.GridColor = System.Drawing.Color.Black;
            this.hierarchicalLevelsDataGridView.Location = new System.Drawing.Point(514, 211);
            this.hierarchicalLevelsDataGridView.Name = "hierarchicalLevelsDataGridView";
            this.hierarchicalLevelsDataGridView.RowHeadersVisible = false;
            this.hierarchicalLevelsDataGridView.Size = new System.Drawing.Size(211, 243);
            this.hierarchicalLevelsDataGridView.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 463);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Новая матрица инцидентности";
            // 
            // outputMatrixDataGridView
            // 
            this.outputMatrixDataGridView.AllowUserToAddRows = false;
            this.outputMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.outputMatrixDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.outputMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputMatrixDataGridView.GridColor = System.Drawing.Color.Black;
            this.outputMatrixDataGridView.Location = new System.Drawing.Point(14, 481);
            this.outputMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputMatrixDataGridView.Name = "outputMatrixDataGridView";
            this.outputMatrixDataGridView.RowHeadersWidth = 70;
            this.outputMatrixDataGridView.Size = new System.Drawing.Size(492, 243);
            this.outputMatrixDataGridView.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 735);
            this.Controls.Add(this.outputMatrixDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hierarchicalLevelsDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftIncidentsTextBox);
            this.Controls.Add(this.searchHierarchicalLevelsButton);
            this.Controls.Add(this.orientedGraphButton);
            this.Controls.Add(this.inputMatrixDataGridView);
            this.Controls.Add(this.sizeMatrixGroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(738, 735);
            this.MinimumSize = new System.Drawing.Size(738, 735);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выделение иерархических уровней ор-графа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputMatrixDataGridView)).EndInit();
            this.sizeMatrixGroupBox.ResumeLayout(false);
            this.sizeMatrixGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countArcNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertexNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hierarchicalLevelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputMatrixDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inputMatrixDataGridView;
        private System.Windows.Forms.GroupBox sizeMatrixGroupBox;
        private System.Windows.Forms.NumericUpDown countArcNumericUpDown;
        private System.Windows.Forms.Label countArcLabel;
        private System.Windows.Forms.NumericUpDown countVertexNumericUpDown;
        private System.Windows.Forms.Label countVertex;
        private System.Windows.Forms.Button orientedGraphButton;
        private System.Windows.Forms.Button searchHierarchicalLevelsButton;
        private System.Windows.Forms.TextBox leftIncidentsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView hierarchicalLevelsDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView outputMatrixDataGridView;
    }
}

