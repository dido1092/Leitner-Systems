namespace Leitner_Systems
{
    partial class FrmInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsert));
            textBoxEnWord = new TextBox();
            textBoxBgWord = new TextBox();
            buttonInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonClear = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButtonInsertFromFile = new ToolStripButton();
            checkBoxInBoxOne = new CheckBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxEnWord
            // 
            textBoxEnWord.Location = new Point(32, 67);
            textBoxEnWord.Name = "textBoxEnWord";
            textBoxEnWord.Size = new Size(242, 23);
            textBoxEnWord.TabIndex = 0;
            // 
            // textBoxBgWord
            // 
            textBoxBgWord.Location = new Point(32, 178);
            textBoxBgWord.Name = "textBoxBgWord";
            textBoxBgWord.Size = new Size(242, 23);
            textBoxBgWord.TabIndex = 1;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(320, 170);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(123, 31);
            buttonInsert.TabIndex = 2;
            buttonInsert.Text = "INSERT";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter En word";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 160);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Bg word";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(358, 49);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(85, 23);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonInsertFromFile });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(488, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInsertFromFile
            // 
            toolStripButtonInsertFromFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonInsertFromFile.Image = (Image)resources.GetObject("toolStripButtonInsertFromFile.Image");
            toolStripButtonInsertFromFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonInsertFromFile.Name = "toolStripButtonInsertFromFile";
            toolStripButtonInsertFromFile.Size = new Size(23, 22);
            toolStripButtonInsertFromFile.Text = "InsertFromFile";
            toolStripButtonInsertFromFile.Click += toolStripButtonInsertFromFile_Click;
            // 
            // checkBoxInBoxOne
            // 
            checkBoxInBoxOne.AutoSize = true;
            checkBoxInBoxOne.Checked = true;
            checkBoxInBoxOne.CheckState = CheckState.Checked;
            checkBoxInBoxOne.Location = new Point(320, 123);
            checkBoxInBoxOne.Name = "checkBoxInBoxOne";
            checkBoxInBoxOne.Size = new Size(77, 19);
            checkBoxInBoxOne.TabIndex = 7;
            checkBoxInBoxOne.Text = "InBoxOne";
            checkBoxInBoxOne.UseVisualStyleBackColor = true;
            // 
            // FrmInsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 268);
            Controls.Add(checkBoxInBoxOne);
            Controls.Add(toolStrip1);
            Controls.Add(buttonClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonInsert);
            Controls.Add(textBoxBgWord);
            Controls.Add(textBoxEnWord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInsert";
            Text = "Insert";
            Load += Insert_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEnWord;
        private TextBox textBoxBgWord;
        private Button buttonInsert;
        private Label label1;
        private Label label2;
        private Button buttonClear;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonInsertFromFile;
        private CheckBox checkBoxInBoxOne;
    }
}