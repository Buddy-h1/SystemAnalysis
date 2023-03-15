namespace IncidenceMatrixConverter
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversionTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.considerDoubleArcsCheckBox = new System.Windows.Forms.CheckBox();
            this.conversionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.outputMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.orientedGraphButton = new System.Windows.Forms.Button();
            this.unorientedGraphButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputMatrixDataGridView)).BeginInit();
            this.sizeMatrixGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countArcNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertexNumericUpDown)).BeginInit();
            this.conversionTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputMatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inputMatrixDataGridView
            // 
            this.inputMatrixDataGridView.AllowUserToAddRows = false;
            this.inputMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.inputMatrixDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.inputMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputMatrixDataGridView.ColumnHeadersVisible = false;
            this.inputMatrixDataGridView.GridColor = System.Drawing.Color.Black;
            this.inputMatrixDataGridView.Location = new System.Drawing.Point(14, 182);
            this.inputMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputMatrixDataGridView.Name = "inputMatrixDataGridView";
            this.inputMatrixDataGridView.RowHeadersVisible = false;
            this.inputMatrixDataGridView.Size = new System.Drawing.Size(423, 223);
            this.inputMatrixDataGridView.TabIndex = 4;
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
            this.sizeMatrixGroupBox.Size = new System.Drawing.Size(423, 90);
            this.sizeMatrixGroupBox.TabIndex = 4;
            this.sizeMatrixGroupBox.TabStop = false;
            this.sizeMatrixGroupBox.Text = "Размер матрицы";
            // 
            // countArcNumericUpDown
            // 
            this.countArcNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countArcNumericUpDown.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countArcNumericUpDown.Location = new System.Drawing.Point(239, 52);
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
            this.countArcNumericUpDown.ValueChanged += new System.EventHandler(this.countVertexNumericUpDown_ValueChanged);
            // 
            // countArcLabel
            // 
            this.countArcLabel.AutoSize = true;
            this.countArcLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countArcLabel.Location = new System.Drawing.Point(236, 32);
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
            this.countVertexNumericUpDown.ValueChanged += new System.EventHandler(this.countArcNumericUpDown_ValueChanged);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // conversionTypeGroupBox
            // 
            this.conversionTypeGroupBox.Controls.Add(this.considerDoubleArcsCheckBox);
            this.conversionTypeGroupBox.Controls.Add(this.conversionTypeComboBox);
            this.conversionTypeGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conversionTypeGroupBox.Location = new System.Drawing.Point(445, 85);
            this.conversionTypeGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.conversionTypeGroupBox.Name = "conversionTypeGroupBox";
            this.conversionTypeGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.conversionTypeGroupBox.Size = new System.Drawing.Size(213, 90);
            this.conversionTypeGroupBox.TabIndex = 5;
            this.conversionTypeGroupBox.TabStop = false;
            this.conversionTypeGroupBox.Text = "Параметры преобразования";
            // 
            // considerDoubleArcsCheckBox
            // 
            this.considerDoubleArcsCheckBox.AutoSize = true;
            this.considerDoubleArcsCheckBox.Checked = true;
            this.considerDoubleArcsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.considerDoubleArcsCheckBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.considerDoubleArcsCheckBox.Location = new System.Drawing.Point(7, 59);
            this.considerDoubleArcsCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.considerDoubleArcsCheckBox.Name = "considerDoubleArcsCheckBox";
            this.considerDoubleArcsCheckBox.Size = new System.Drawing.Size(176, 19);
            this.considerDoubleArcsCheckBox.TabIndex = 7;
            this.considerDoubleArcsCheckBox.Text = "Дублирующие ребра/дуги";
            this.considerDoubleArcsCheckBox.UseVisualStyleBackColor = true;
            // 
            // conversionTypeComboBox
            // 
            this.conversionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conversionTypeComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conversionTypeComboBox.FormattingEnabled = true;
            this.conversionTypeComboBox.Items.AddRange(new object[] {
            "Матрица смежности",
            "Множество левых инциденций"});
            this.conversionTypeComboBox.Location = new System.Drawing.Point(7, 25);
            this.conversionTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.conversionTypeComboBox.Name = "conversionTypeComboBox";
            this.conversionTypeComboBox.Size = new System.Drawing.Size(198, 23);
            this.conversionTypeComboBox.TabIndex = 8;
            this.conversionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.conversionTypeComboBox_SelectedIndexChanged);
            // 
            // outputMatrixDataGridView
            // 
            this.outputMatrixDataGridView.AllowUserToAddRows = false;
            this.outputMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.outputMatrixDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.outputMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputMatrixDataGridView.ColumnHeadersVisible = false;
            this.outputMatrixDataGridView.GridColor = System.Drawing.Color.Black;
            this.outputMatrixDataGridView.Location = new System.Drawing.Point(445, 182);
            this.outputMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputMatrixDataGridView.Name = "outputMatrixDataGridView";
            this.outputMatrixDataGridView.RowHeadersVisible = false;
            this.outputMatrixDataGridView.Size = new System.Drawing.Size(213, 223);
            this.outputMatrixDataGridView.TabIndex = 6;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Location = new System.Drawing.Point(445, 182);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(213, 223);
            this.outputTextBox.TabIndex = 5;
            this.outputTextBox.Visible = false;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpButton.Location = new System.Drawing.Point(531, 29);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(127, 27);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Помощь";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.convertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.convertButton.Location = new System.Drawing.Point(518, 421);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(140, 40);
            this.convertButton.TabIndex = 14;
            this.convertButton.Text = "Преобразовать";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(14, 421);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 40);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // orientedGraphButton
            // 
            this.orientedGraphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.orientedGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.orientedGraphButton.FlatAppearance.BorderSize = 0;
            this.orientedGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orientedGraphButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orientedGraphButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orientedGraphButton.Location = new System.Drawing.Point(117, 421);
            this.orientedGraphButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orientedGraphButton.Name = "orientedGraphButton";
            this.orientedGraphButton.Size = new System.Drawing.Size(165, 40);
            this.orientedGraphButton.TabIndex = 16;
            this.orientedGraphButton.Text = "Пример (Ор-граф)";
            this.orientedGraphButton.UseVisualStyleBackColor = false;
            this.orientedGraphButton.Click += new System.EventHandler(this.orientedGraphButton_Click);
            // 
            // unorientedGraphButton
            // 
            this.unorientedGraphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.unorientedGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.unorientedGraphButton.FlatAppearance.BorderSize = 0;
            this.unorientedGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unorientedGraphButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unorientedGraphButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.unorientedGraphButton.Location = new System.Drawing.Point(290, 421);
            this.unorientedGraphButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unorientedGraphButton.Name = "unorientedGraphButton";
            this.unorientedGraphButton.Size = new System.Drawing.Size(175, 40);
            this.unorientedGraphButton.TabIndex = 17;
            this.unorientedGraphButton.Text = "Пример (Неор-граф)";
            this.unorientedGraphButton.UseVisualStyleBackColor = false;
            this.unorientedGraphButton.Click += new System.EventHandler(this.unorientedGraphButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.Controls.Add(this.unorientedGraphButton);
            this.Controls.Add(this.orientedGraphButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputMatrixDataGridView);
            this.Controls.Add(this.conversionTypeGroupBox);
            this.Controls.Add(this.inputMatrixDataGridView);
            this.Controls.Add(this.sizeMatrixGroupBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 69, 4, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преобразователь матрицы инциденций";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputMatrixDataGridView)).EndInit();
            this.sizeMatrixGroupBox.ResumeLayout(false);
            this.sizeMatrixGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countArcNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertexNumericUpDown)).EndInit();
            this.conversionTypeGroupBox.ResumeLayout(false);
            this.conversionTypeGroupBox.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox conversionTypeGroupBox;
        private System.Windows.Forms.DataGridView outputMatrixDataGridView;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.CheckBox considerDoubleArcsCheckBox;
        private System.Windows.Forms.ComboBox conversionTypeComboBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button orientedGraphButton;
        private System.Windows.Forms.Button unorientedGraphButton;
    }
}

