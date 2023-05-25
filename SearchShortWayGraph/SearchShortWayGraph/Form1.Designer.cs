
namespace SearchShortWayGraph
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
            this.countVertexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countVertex = new System.Windows.Forms.Label();
            this.distanceMatrixLabel = new System.Windows.Forms.Label();
            this.distanceMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.startGetShortWayMatrix = new System.Windows.Forms.Button();
            this.orientedGraphButton = new System.Windows.Forms.Button();
            this.shortWayMatrixLabel = new System.Windows.Forms.Label();
            this.shortWayMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.correctionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countVertexNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceMatrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortWayMatrixDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countVertexNumericUpDown
            // 
            this.countVertexNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countVertexNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countVertexNumericUpDown.Location = new System.Drawing.Point(10, 36);
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
            this.countVertexNumericUpDown.Size = new System.Drawing.Size(175, 21);
            this.countVertexNumericUpDown.TabIndex = 1;
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
            this.countVertex.Location = new System.Drawing.Point(7, 16);
            this.countVertex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countVertex.Name = "countVertex";
            this.countVertex.Size = new System.Drawing.Size(94, 15);
            this.countVertex.TabIndex = 2;
            this.countVertex.Text = "Кол-во вершин";
            // 
            // distanceMatrixLabel
            // 
            this.distanceMatrixLabel.AutoSize = true;
            this.distanceMatrixLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceMatrixLabel.Location = new System.Drawing.Point(5, 145);
            this.distanceMatrixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.distanceMatrixLabel.Name = "distanceMatrixLabel";
            this.distanceMatrixLabel.Size = new System.Drawing.Size(128, 15);
            this.distanceMatrixLabel.TabIndex = 27;
            this.distanceMatrixLabel.Text = "Матрица расстояний";
            // 
            // distanceMatrixDataGridView
            // 
            this.distanceMatrixDataGridView.AllowUserToAddRows = false;
            this.distanceMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.distanceMatrixDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.distanceMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distanceMatrixDataGridView.GridColor = System.Drawing.Color.Black;
            this.distanceMatrixDataGridView.Location = new System.Drawing.Point(7, 163);
            this.distanceMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.distanceMatrixDataGridView.Name = "distanceMatrixDataGridView";
            this.distanceMatrixDataGridView.RowHeadersWidth = 70;
            this.distanceMatrixDataGridView.Size = new System.Drawing.Size(282, 243);
            this.distanceMatrixDataGridView.TabIndex = 26;
            // 
            // startGetShortWayMatrix
            // 
            this.startGetShortWayMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.startGetShortWayMatrix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.startGetShortWayMatrix.FlatAppearance.BorderSize = 0;
            this.startGetShortWayMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGetShortWayMatrix.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGetShortWayMatrix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startGetShortWayMatrix.Location = new System.Drawing.Point(403, 16);
            this.startGetShortWayMatrix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startGetShortWayMatrix.Name = "startGetShortWayMatrix";
            this.startGetShortWayMatrix.Size = new System.Drawing.Size(172, 40);
            this.startGetShortWayMatrix.TabIndex = 29;
            this.startGetShortWayMatrix.Text = "Начать";
            this.startGetShortWayMatrix.UseVisualStyleBackColor = false;
            this.startGetShortWayMatrix.Click += new System.EventHandler(this.startGetShortWayMatrix_Click);
            // 
            // orientedGraphButton
            // 
            this.orientedGraphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.orientedGraphButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.orientedGraphButton.FlatAppearance.BorderSize = 0;
            this.orientedGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orientedGraphButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orientedGraphButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orientedGraphButton.Location = new System.Drawing.Point(204, 16);
            this.orientedGraphButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orientedGraphButton.Name = "orientedGraphButton";
            this.orientedGraphButton.Size = new System.Drawing.Size(172, 40);
            this.orientedGraphButton.TabIndex = 28;
            this.orientedGraphButton.Text = "Пример (Ор-граф)";
            this.orientedGraphButton.UseVisualStyleBackColor = false;
            this.orientedGraphButton.Click += new System.EventHandler(this.orientedGraphButton_Click);
            // 
            // shortWayMatrixLabel
            // 
            this.shortWayMatrixLabel.AutoSize = true;
            this.shortWayMatrixLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shortWayMatrixLabel.Location = new System.Drawing.Point(308, 145);
            this.shortWayMatrixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shortWayMatrixLabel.Name = "shortWayMatrixLabel";
            this.shortWayMatrixLabel.Size = new System.Drawing.Size(164, 15);
            this.shortWayMatrixLabel.TabIndex = 31;
            this.shortWayMatrixLabel.Text = "Матрица кратчайших путей";
            // 
            // shortWayMatrixDataGridView
            // 
            this.shortWayMatrixDataGridView.AllowUserToAddRows = false;
            this.shortWayMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.shortWayMatrixDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.shortWayMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortWayMatrixDataGridView.GridColor = System.Drawing.Color.Black;
            this.shortWayMatrixDataGridView.Location = new System.Drawing.Point(310, 163);
            this.shortWayMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shortWayMatrixDataGridView.Name = "shortWayMatrixDataGridView";
            this.shortWayMatrixDataGridView.RowHeadersWidth = 70;
            this.shortWayMatrixDataGridView.Size = new System.Drawing.Size(282, 243);
            this.shortWayMatrixDataGridView.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countVertex);
            this.groupBox1.Controls.Add(this.countVertexNumericUpDown);
            this.groupBox1.Controls.Add(this.orientedGraphButton);
            this.groupBox1.Controls.Add(this.startGetShortWayMatrix);
            this.groupBox1.Location = new System.Drawing.Point(7, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 67);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // correctionButton
            // 
            this.correctionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.correctionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.correctionButton.FlatAppearance.BorderSize = 0;
            this.correctionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.correctionButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.correctionButton.Location = new System.Drawing.Point(320, 32);
            this.correctionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.correctionButton.Name = "correctionButton";
            this.correctionButton.Size = new System.Drawing.Size(20, 20);
            this.correctionButton.TabIndex = 30;
            this.correctionButton.UseVisualStyleBackColor = false;
            this.correctionButton.Click += new System.EventHandler(this.correctionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 415);
            this.Controls.Add(this.correctionButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shortWayMatrixLabel);
            this.Controls.Add(this.shortWayMatrixDataGridView);
            this.Controls.Add(this.distanceMatrixLabel);
            this.Controls.Add(this.distanceMatrixDataGridView);
            this.MaximumSize = new System.Drawing.Size(602, 415);
            this.MinimumSize = new System.Drawing.Size(602, 415);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск кратчайших путей графа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countVertexNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceMatrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortWayMatrixDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown countVertexNumericUpDown;
        private System.Windows.Forms.Label countVertex;
        private System.Windows.Forms.Label distanceMatrixLabel;
        private System.Windows.Forms.DataGridView distanceMatrixDataGridView;
        private System.Windows.Forms.Button startGetShortWayMatrix;
        private System.Windows.Forms.Button orientedGraphButton;
        private System.Windows.Forms.Label shortWayMatrixLabel;
        private System.Windows.Forms.DataGridView shortWayMatrixDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button correctionButton;
    }
}

