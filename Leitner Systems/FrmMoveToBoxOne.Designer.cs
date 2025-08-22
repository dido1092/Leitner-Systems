namespace Leitner_Systems
{
    partial class FrmMoveToBoxOne
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
            buttonLoadEnBgWords = new Button();
            richTextBoxEnBgWords = new RichTextBox();
            labelRows = new Label();
            buttonMoveToBoxOne = new Button();
            SuspendLayout();
            // 
            // buttonLoadEnBgWords
            // 
            buttonLoadEnBgWords.Location = new Point(27, 46);
            buttonLoadEnBgWords.Name = "buttonLoadEnBgWords";
            buttonLoadEnBgWords.Size = new Size(115, 33);
            buttonLoadEnBgWords.TabIndex = 0;
            buttonLoadEnBgWords.Text = "Load EnBgWords";
            buttonLoadEnBgWords.UseVisualStyleBackColor = true;
            buttonLoadEnBgWords.Click += buttonLoadEnBgWords_Click;
            // 
            // richTextBoxEnBgWords
            // 
            richTextBoxEnBgWords.Location = new Point(27, 104);
            richTextBoxEnBgWords.Name = "richTextBoxEnBgWords";
            richTextBoxEnBgWords.Size = new Size(377, 468);
            richTextBoxEnBgWords.TabIndex = 1;
            richTextBoxEnBgWords.Text = "";
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Location = new Point(27, 589);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(35, 15);
            labelRows.TabIndex = 2;
            labelRows.Text = "Rows";
            // 
            // buttonMoveToBoxOne
            // 
            buttonMoveToBoxOne.Location = new Point(420, 104);
            buttonMoveToBoxOne.Name = "buttonMoveToBoxOne";
            buttonMoveToBoxOne.Size = new Size(119, 33);
            buttonMoveToBoxOne.TabIndex = 3;
            buttonMoveToBoxOne.Text = "Move To Box One";
            buttonMoveToBoxOne.UseVisualStyleBackColor = true;
            buttonMoveToBoxOne.Click += buttonMoveToBoxOne_Click;
            // 
            // FrmMoveToBoxOne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 642);
            Controls.Add(buttonMoveToBoxOne);
            Controls.Add(labelRows);
            Controls.Add(richTextBoxEnBgWords);
            Controls.Add(buttonLoadEnBgWords);
            Name = "FrmMoveToBoxOne";
            Text = "FrmMoveToBoxOne";
            Load += FrmMoveToBoxOne_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLoadEnBgWords;
        private RichTextBox richTextBoxEnBgWords;
        private Label labelRows;
        private Button buttonMoveToBoxOne;
    }
}