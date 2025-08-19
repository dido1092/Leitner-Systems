namespace Leitner_Systems
{
    partial class EnBgWordsTable
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
            enBgWordBindingSource1 = new BindingSource(components);
            enBgWordBindingSource = new BindingSource(components);
            labelWords = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonRefresh = new Button();
            buttonDelete = new Button();
            buttonUpDate = new Button();
            buttonInsert = new Button();
            dataGridViewEnBgWords = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            enBgWordBindingSource3 = new BindingSource(components);
            enBgWordBindingSource2 = new BindingSource(components);
            checkBoxEnWord = new CheckBox();
            checkBoxBgWord = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnBgWords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // enBgWordBindingSource1
            // 
            enBgWordBindingSource1.DataSource = typeof(LeitnerSystemsDataModels.EnBgWord);
            // 
            // enBgWordBindingSource
            // 
            enBgWordBindingSource.DataSource = typeof(LeitnerSystemsDataModels.EnBgWord);
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
            textBoxSearch.Location = new Point(12, 70);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(321, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(339, 69);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(122, 23);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(492, 26);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(109, 33);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "REFRESH";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(512, 698);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(89, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpDate
            // 
            buttonUpDate.Location = new Point(512, 195);
            buttonUpDate.Name = "buttonUpDate";
            buttonUpDate.Size = new Size(89, 29);
            buttonUpDate.TabIndex = 4;
            buttonUpDate.Text = "UPDATE";
            buttonUpDate.UseVisualStyleBackColor = true;
            buttonUpDate.Click += buttonUpDate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(512, 122);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(89, 23);
            buttonInsert.TabIndex = 5;
            buttonInsert.Text = "INSERT";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // dataGridViewEnBgWords
            // 
            dataGridViewEnBgWords.AutoGenerateColumns = false;
            dataGridViewEnBgWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnBgWords.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewEnBgWords.DataSource = enBgWordBindingSource3;
            dataGridViewEnBgWords.Location = new Point(12, 122);
            dataGridViewEnBgWords.Name = "dataGridViewEnBgWords";
            dataGridViewEnBgWords.Size = new Size(494, 605);
            dataGridViewEnBgWords.TabIndex = 6;
            dataGridViewEnBgWords.CellContentClick += dataGridViewEnBgWords_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "EnWord";
            dataGridViewTextBoxColumn2.HeaderText = "EnWord";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "BgWord";
            dataGridViewTextBoxColumn3.HeaderText = "BgWord";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // enBgWordBindingSource3
            // 
            enBgWordBindingSource3.DataSource = typeof(LeitnerSystemsDataModels.EnBgWord);
            // 
            // enBgWordBindingSource2
            // 
            enBgWordBindingSource2.DataSource = typeof(LeitnerSystemsDataModels.EnBgWord);
            // 
            // checkBoxEnWord
            // 
            checkBoxEnWord.AutoSize = true;
            checkBoxEnWord.Location = new Point(12, 26);
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
            checkBoxBgWord.Location = new Point(111, 26);
            checkBoxBgWord.Name = "checkBoxBgWord";
            checkBoxBgWord.Size = new Size(70, 19);
            checkBoxBgWord.TabIndex = 8;
            checkBoxBgWord.Text = "Bg word";
            checkBoxBgWord.UseVisualStyleBackColor = true;
            checkBoxBgWord.CheckedChanged += checkBoxBgWord_CheckedChanged;
            // 
            // EnBgWordsTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 765);
            Controls.Add(checkBoxBgWord);
            Controls.Add(checkBoxEnWord);
            Controls.Add(dataGridViewEnBgWords);
            Controls.Add(buttonInsert);
            Controls.Add(buttonUpDate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelWords);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EnBgWordsTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnBgWordsTable";
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnBgWords).EndInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enBgWordBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelWords;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonRefresh;
        private Button buttonDelete;
        private Button buttonUpDate;
        private Button buttonInsert;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private BindingSource enBgWordBindingSource;
        private BindingSource enBgWordBindingSource1;
        private DataGridView dataGridViewEnBgWords;
        private BindingSource enBgWordBindingSource2;
        private BindingSource enBgWordBindingSource3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CheckBox checkBoxEnWord;
        private CheckBox checkBoxBgWord;
    }
}