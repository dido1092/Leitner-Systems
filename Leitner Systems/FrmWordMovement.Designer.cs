namespace Leitner_Systems
{
    partial class FrmWordMovement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewWordMovement = new DataGridView();
            labelLine = new Label();
            buttonRefresh = new Button();
            wordMovementBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bgWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fromBoxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toBoxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayLanguageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hintDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            insertDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWordMovement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWordMovement
            // 
            dataGridViewWordMovement.AutoGenerateColumns = false;
            dataGridViewWordMovement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWordMovement.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, enWordDataGridViewTextBoxColumn, bgWordDataGridViewTextBoxColumn, fromBoxDataGridViewTextBoxColumn, toBoxDataGridViewTextBoxColumn, displayLanguageDataGridViewTextBoxColumn, hintDataGridViewCheckBoxColumn, insertDateDataGridViewTextBoxColumn });
            dataGridViewWordMovement.DataSource = wordMovementBindingSource;
            dataGridViewWordMovement.Location = new Point(23, 110);
            dataGridViewWordMovement.Name = "dataGridViewWordMovement";
            dataGridViewWordMovement.Size = new Size(861, 538);
            dataGridViewWordMovement.TabIndex = 0;
            // 
            // labelLine
            // 
            labelLine.AutoSize = true;
            labelLine.Location = new Point(23, 663);
            labelLine.Name = "labelLine";
            labelLine.Size = new Size(34, 15);
            labelLine.TabIndex = 1;
            labelLine.Text = "Lines";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(936, 32);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(96, 34);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // wordMovementBindingSource
            // 
            wordMovementBindingSource.DataSource = typeof(LeitnerSystemsDataModels.WordMovement);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // enWordDataGridViewTextBoxColumn
            // 
            enWordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            enWordDataGridViewTextBoxColumn.DataPropertyName = "EnWord";
            enWordDataGridViewTextBoxColumn.HeaderText = "EnWord";
            enWordDataGridViewTextBoxColumn.Name = "enWordDataGridViewTextBoxColumn";
            // 
            // bgWordDataGridViewTextBoxColumn
            // 
            bgWordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bgWordDataGridViewTextBoxColumn.DataPropertyName = "BgWord";
            bgWordDataGridViewTextBoxColumn.HeaderText = "BgWord";
            bgWordDataGridViewTextBoxColumn.Name = "bgWordDataGridViewTextBoxColumn";
            // 
            // fromBoxDataGridViewTextBoxColumn
            // 
            fromBoxDataGridViewTextBoxColumn.DataPropertyName = "FromBox";
            fromBoxDataGridViewTextBoxColumn.HeaderText = "FromBox";
            fromBoxDataGridViewTextBoxColumn.Name = "fromBoxDataGridViewTextBoxColumn";
            // 
            // toBoxDataGridViewTextBoxColumn
            // 
            toBoxDataGridViewTextBoxColumn.DataPropertyName = "ToBox";
            toBoxDataGridViewTextBoxColumn.HeaderText = "ToBox";
            toBoxDataGridViewTextBoxColumn.Name = "toBoxDataGridViewTextBoxColumn";
            // 
            // displayLanguageDataGridViewTextBoxColumn
            // 
            displayLanguageDataGridViewTextBoxColumn.DataPropertyName = "DisplayLanguage";
            displayLanguageDataGridViewTextBoxColumn.HeaderText = "DisplayLanguage";
            displayLanguageDataGridViewTextBoxColumn.Name = "displayLanguageDataGridViewTextBoxColumn";
            // 
            // hintDataGridViewCheckBoxColumn
            // 
            hintDataGridViewCheckBoxColumn.DataPropertyName = "Hint";
            hintDataGridViewCheckBoxColumn.HeaderText = "Hint";
            hintDataGridViewCheckBoxColumn.Name = "hintDataGridViewCheckBoxColumn";
            // 
            // insertDateDataGridViewTextBoxColumn
            // 
            insertDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            insertDateDataGridViewTextBoxColumn.DataPropertyName = "InsertDate";
            insertDateDataGridViewTextBoxColumn.HeaderText = "InsertDate";
            insertDateDataGridViewTextBoxColumn.Name = "insertDateDataGridViewTextBoxColumn";
            // 
            // FrmWordMovement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 703);
            Controls.Add(buttonRefresh);
            Controls.Add(labelLine);
            Controls.Add(dataGridViewWordMovement);
            Name = "FrmWordMovement";
            Text = "FrmWordMovement";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWordMovement).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewWordMovement;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromBoxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toBoxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayLanguageDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hintDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn insertDateDataGridViewTextBoxColumn;
        private BindingSource wordMovementBindingSource;
        private Label labelLine;
        private Button buttonRefresh;
    }
}