namespace Leitner_Systems
{
    partial class FrmTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTables));
            enBgWordBindingSource1 = new BindingSource(components);
            enBgWordBindingSource = new BindingSource(components);
            labelWords = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonDelete = new Button();
            buttonUpDate = new Button();
            buttonInsert = new Button();
            enBgWordBindingSource3 = new BindingSource(components);
            enBgWordBindingSource2 = new BindingSource(components);
            checkBoxEnWord = new CheckBox();
            checkBoxBgWord = new CheckBox();
            comboBoxTables = new ComboBox();
            label1 = new Label();
            buttonLoad = new Button();
            boxOneBindingSource = new BindingSource(components);
            dataGridViewTables = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            insertDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            performanceTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordMovementBindingSource = new BindingSource(components);
            buttonSet = new Button();
            label2 = new Label();
            comboBoxSet = new ComboBox();
            textBoxIdFirst = new TextBox();
            textBoxIdLast = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttonSelectIds = new Button();
            buttonClearIds = new Button();
            labelInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxOneBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelWords
            // 
            labelWords.AutoSize = true;
            labelWords.Location = new Point(13, 741);
            labelWords.Name = "labelWords";
            labelWords.Size = new Size(44, 15);
            labelWords.TabIndex = 1;
            labelWords.Text = "Words:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 122);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(164, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(182, 122);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(115, 23);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(645, 663);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(89, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpDate
            // 
            buttonUpDate.Location = new Point(645, 161);
            buttonUpDate.Name = "buttonUpDate";
            buttonUpDate.Size = new Size(89, 29);
            buttonUpDate.TabIndex = 4;
            buttonUpDate.Text = "UPDATE";
            buttonUpDate.UseVisualStyleBackColor = true;
            buttonUpDate.Click += buttonUpDate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(645, 36);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(89, 23);
            buttonInsert.TabIndex = 5;
            buttonInsert.Text = "INSERT";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // checkBoxEnWord
            // 
            checkBoxEnWord.AutoSize = true;
            checkBoxEnWord.Location = new Point(13, 87);
            checkBoxEnWord.Name = "checkBoxEnWord";
            checkBoxEnWord.Size = new Size(69, 19);
            checkBoxEnWord.TabIndex = 7;
            checkBoxEnWord.Text = "En word";
            checkBoxEnWord.UseVisualStyleBackColor = true;
            checkBoxEnWord.CheckedChanged += checkBoxEnWord_CheckedChanged;
            // 
            // checkBoxBgWord
            // 
            checkBoxBgWord.AutoSize = true;
            checkBoxBgWord.Location = new Point(106, 87);
            checkBoxBgWord.Name = "checkBoxBgWord";
            checkBoxBgWord.Size = new Size(70, 19);
            checkBoxBgWord.TabIndex = 8;
            checkBoxBgWord.Text = "Bg word";
            checkBoxBgWord.UseVisualStyleBackColor = true;
            checkBoxBgWord.CheckedChanged += checkBoxBgWord_CheckedChanged;
            // 
            // comboBoxTables
            // 
            comboBoxTables.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTables.FormattingEnabled = true;
            comboBoxTables.Items.AddRange(new object[] { "BoxOnes", "BoxTwos", "BoxThrees", "BoxFours", "BoxFives", "EnBgWords" });
            comboBoxTables.Location = new Point(13, 36);
            comboBoxTables.Name = "comboBoxTables";
            comboBoxTables.Size = new Size(128, 23);
            comboBoxTables.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Tables";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(158, 36);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 11;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // boxOneBindingSource
            // 
            boxOneBindingSource.DataSource = typeof(LeitnerSystemsDataModels.BoxOne);
            // 
            // dataGridViewTables
            // 
            dataGridViewTables.AutoGenerateColumns = false;
            dataGridViewTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTables.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, insertDateDataGridViewTextBoxColumn, performanceTimeDataGridViewTextBoxColumn });
            dataGridViewTables.DataSource = boxOneBindingSource;
            dataGridViewTables.Location = new Point(13, 161);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.Size = new Size(623, 531);
            dataGridViewTables.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            dataGridViewTextBoxColumn4.HeaderText = "Id";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "EnWord";
            dataGridViewTextBoxColumn5.HeaderText = "EnWord";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "BgWord";
            dataGridViewTextBoxColumn6.HeaderText = "BgWord";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // insertDateDataGridViewTextBoxColumn
            // 
            insertDateDataGridViewTextBoxColumn.DataPropertyName = "InsertDate";
            insertDateDataGridViewTextBoxColumn.HeaderText = "InsertDate";
            insertDateDataGridViewTextBoxColumn.Name = "insertDateDataGridViewTextBoxColumn";
            // 
            // performanceTimeDataGridViewTextBoxColumn
            // 
            performanceTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            performanceTimeDataGridViewTextBoxColumn.DataPropertyName = "PerformanceTime";
            performanceTimeDataGridViewTextBoxColumn.HeaderText = "PerformanceTime";
            performanceTimeDataGridViewTextBoxColumn.Name = "performanceTimeDataGridViewTextBoxColumn";
            // 
            // wordMovementBindingSource
            // 
            wordMovementBindingSource.DataSource = typeof(LeitnerSystemsDataModels.WordMovement);
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(645, 122);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(89, 23);
            buttonSet.TabIndex = 13;
            buttonSet.Text = "SET";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 105);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 14;
            label2.Text = "Set PerformanceTime";
            // 
            // comboBoxSet
            // 
            comboBoxSet.FormattingEnabled = true;
            comboBoxSet.Items.AddRange(new object[] { "=Now", "=InsertDate", "=First" });
            comboBoxSet.Location = new Point(503, 123);
            comboBoxSet.Name = "comboBoxSet";
            comboBoxSet.Size = new Size(133, 23);
            comboBoxSet.TabIndex = 15;
            // 
            // textBoxIdFirst
            // 
            textBoxIdFirst.Location = new Point(349, 123);
            textBoxIdFirst.Name = "textBoxIdFirst";
            textBoxIdFirst.Size = new Size(66, 23);
            textBoxIdFirst.TabIndex = 16;
            // 
            // textBoxIdLast
            // 
            textBoxIdLast.Location = new Point(431, 123);
            textBoxIdLast.Name = "textBoxIdLast";
            textBoxIdLast.Size = new Size(66, 23);
            textBoxIdLast.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 105);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 18;
            label3.Text = "Id >=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 105);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 19;
            label4.Text = "Id <=";
            // 
            // buttonSelectIds
            // 
            buttonSelectIds.Location = new Point(645, 281);
            buttonSelectIds.Name = "buttonSelectIds";
            buttonSelectIds.Size = new Size(89, 31);
            buttonSelectIds.TabIndex = 20;
            buttonSelectIds.Text = "Select Id's";
            buttonSelectIds.UseVisualStyleBackColor = true;
            buttonSelectIds.Click += buttonSelectIds_Click;
            // 
            // buttonClearIds
            // 
            buttonClearIds.Location = new Point(645, 347);
            buttonClearIds.Name = "buttonClearIds";
            buttonClearIds.Size = new Size(89, 31);
            buttonClearIds.TabIndex = 22;
            buttonClearIds.Text = "Clear Id's";
            buttonClearIds.UseVisualStyleBackColor = true;
            buttonClearIds.Click += buttonClearIds_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(13, 705);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(28, 15);
            labelInfo.TabIndex = 23;
            labelInfo.Text = "Info";
            // 
            // FrmTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 765);
            Controls.Add(labelInfo);
            Controls.Add(buttonClearIds);
            Controls.Add(buttonSelectIds);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxIdLast);
            Controls.Add(textBoxIdFirst);
            Controls.Add(comboBoxSet);
            Controls.Add(label2);
            Controls.Add(buttonSet);
            Controls.Add(dataGridViewTables);
            Controls.Add(buttonLoad);
            Controls.Add(label1);
            Controls.Add(comboBoxTables);
            Controls.Add(checkBoxBgWord);
            Controls.Add(checkBoxEnWord);
            Controls.Add(buttonInsert);
            Controls.Add(buttonUpDate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelWords);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmTables";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tables";
            Load += FrmTables_Load;
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxOneBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelWords;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonDelete;
        private Button buttonUpDate;
        private Button buttonInsert;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private BindingSource enBgWordBindingSource;
        private BindingSource enBgWordBindingSource1;
        private BindingSource enBgWordBindingSource2;
        private BindingSource enBgWordBindingSource3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CheckBox checkBoxEnWord;
        private CheckBox checkBoxBgWord;
        private ComboBox comboBoxTables;
        private Label label1;
        private Button buttonLoad;
        private BindingSource boxOneBindingSource;
        private DataGridView dataGridViewTables;
        private BindingSource wordMovementBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn insertDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn performanceTimeDataGridViewTextBoxColumn;
        private Button buttonSet;
        private Label label2;
        private ComboBox comboBoxSet;
        private TextBox textBoxIdFirst;
        private TextBox textBoxIdLast;
        private Label label3;
        private Label label4;
        private Button buttonSelectIds;
        private Button buttonClearIds;
        private Label labelInfo;
    }
}