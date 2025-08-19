namespace Leitner_Systems
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButtonInsert = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonEnBgWords = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonInsert, toolStripSeparator1, toolStripButtonEnBgWords });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInsert
            // 
            toolStripButtonInsert.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonInsert.Image = (Image)resources.GetObject("toolStripButtonInsert.Image");
            toolStripButtonInsert.ImageTransparentColor = Color.Magenta;
            toolStripButtonInsert.Name = "toolStripButtonInsert";
            toolStripButtonInsert.Size = new Size(23, 22);
            toolStripButtonInsert.Text = "INSERT";
            toolStripButtonInsert.Click += toolStripButtonInsert_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButtonEnBgWords
            // 
            toolStripButtonEnBgWords.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEnBgWords.Image = (Image)resources.GetObject("toolStripButtonEnBgWords.Image");
            toolStripButtonEnBgWords.ImageTransparentColor = Color.Magenta;
            toolStripButtonEnBgWords.Name = "toolStripButtonEnBgWords";
            toolStripButtonEnBgWords.Size = new Size(23, 22);
            toolStripButtonEnBgWords.Text = "EnBgWords";
            toolStripButtonEnBgWords.Click += toolStripButtonEnBgWords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LeitnerSystems";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonInsert;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonEnBgWords;
    }
}
