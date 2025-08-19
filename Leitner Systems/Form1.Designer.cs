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
            toolStripButtonTables = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonMoveToBoxOne = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            buttonTest = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonInsert, toolStripSeparator1, toolStripButtonTables, toolStripSeparator2, toolStripButtonMoveToBoxOne, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(676, 25);
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
            // toolStripButtonTables
            // 
            toolStripButtonTables.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonTables.Image = (Image)resources.GetObject("toolStripButtonTables.Image");
            toolStripButtonTables.ImageTransparentColor = Color.Magenta;
            toolStripButtonTables.Name = "toolStripButtonTables";
            toolStripButtonTables.Size = new Size(23, 22);
            toolStripButtonTables.Text = "Tables";
            toolStripButtonTables.Click += toolStripButtonTables_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButtonMoveToBoxOne
            // 
            toolStripButtonMoveToBoxOne.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonMoveToBoxOne.Image = (Image)resources.GetObject("toolStripButtonMoveToBoxOne.Image");
            toolStripButtonMoveToBoxOne.ImageTransparentColor = Color.Magenta;
            toolStripButtonMoveToBoxOne.Name = "toolStripButtonMoveToBoxOne";
            toolStripButtonMoveToBoxOne.Size = new Size(23, 22);
            toolStripButtonMoveToBoxOne.Text = "MoveToBoxOne";
            toolStripButtonMoveToBoxOne.Click += toolStripButtonMoveToBoxOne_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // buttonTest
            // 
            buttonTest.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTest.Location = new Point(120, 115);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(390, 115);
            buttonTest.TabIndex = 1;
            buttonTest.Text = "T E S T";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 386);
            Controls.Add(buttonTest);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripButton toolStripButtonTables;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonMoveToBoxOne;
        private ToolStripSeparator toolStripSeparator3;
        private Button buttonTest;
    }
}
