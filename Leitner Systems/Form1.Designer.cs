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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButtonInsert = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonMoveToBoxOne = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonTables = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButtonWordMovement = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonChart = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtonTimers = new ToolStripButton();
            buttonTest = new Button();
            notifyIconLS = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            timerOne = new System.Windows.Forms.Timer(components);
            timerTwo = new System.Windows.Forms.Timer(components);
            timerThree = new System.Windows.Forms.Timer(components);
            timerFour = new System.Windows.Forms.Timer(components);
            timerFive = new System.Windows.Forms.Timer(components);
            labelBoxOne = new Label();
            labelBoxTwo = new Label();
            labelBoxThree = new Label();
            labelBoxFour = new Label();
            labelBoxFive = new Label();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonInsert, toolStripSeparator1, toolStripButtonMoveToBoxOne, toolStripSeparator2, toolStripButtonTables, toolStripSeparator3, toolStripButtonWordMovement, toolStripSeparator5, toolStripButtonChart, toolStripSeparator4, toolStripButtonTimers });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(576, 25);
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
            toolStripButtonInsert.Text = "Insert";
            toolStripButtonInsert.Click += toolStripButtonInsert_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
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
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripButtonWordMovement
            // 
            toolStripButtonWordMovement.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonWordMovement.Image = (Image)resources.GetObject("toolStripButtonWordMovement.Image");
            toolStripButtonWordMovement.ImageTransparentColor = Color.Magenta;
            toolStripButtonWordMovement.Name = "toolStripButtonWordMovement";
            toolStripButtonWordMovement.Size = new Size(23, 22);
            toolStripButtonWordMovement.Text = "Word Movement";
            toolStripButtonWordMovement.Click += toolStripButtonWordMovement_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButtonChart
            // 
            toolStripButtonChart.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonChart.Image = (Image)resources.GetObject("toolStripButtonChart.Image");
            toolStripButtonChart.ImageTransparentColor = Color.Magenta;
            toolStripButtonChart.Name = "toolStripButtonChart";
            toolStripButtonChart.Size = new Size(23, 22);
            toolStripButtonChart.Text = "Charts";
            toolStripButtonChart.Click += toolStripButtonChart_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripButtonTimers
            // 
            toolStripButtonTimers.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonTimers.Image = (Image)resources.GetObject("toolStripButtonTimers.Image");
            toolStripButtonTimers.ImageTransparentColor = Color.Magenta;
            toolStripButtonTimers.Name = "toolStripButtonTimers";
            toolStripButtonTimers.Size = new Size(23, 22);
            toolStripButtonTimers.Text = "Timers";
            toolStripButtonTimers.Click += toolStripButtonTimers_Click;
            // 
            // buttonTest
            // 
            buttonTest.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTest.Location = new Point(84, 85);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(390, 115);
            buttonTest.TabIndex = 1;
            buttonTest.Text = "T E S T";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // notifyIconLS
            // 
            notifyIconLS.BalloonTipTitle = "LeitnerSystems";
            notifyIconLS.ContextMenuStrip = contextMenuStrip1;
            notifyIconLS.Icon = (Icon)resources.GetObject("notifyIconLS.Icon");
            notifyIconLS.Text = "LeitnerSystems";
            notifyIconLS.Visible = true;
            notifyIconLS.MouseDoubleClick += notifyIconLS_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(103, 22);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // timerOne
            // 
            timerOne.Enabled = true;
            timerOne.Interval = 60000;
            timerOne.Tick += timerOne_Tick;
            // 
            // timerTwo
            // 
            timerTwo.Enabled = true;
            timerTwo.Interval = 60000;
            timerTwo.Tick += timerTwo_Tick;
            // 
            // timerThree
            // 
            timerThree.Enabled = true;
            timerThree.Interval = 60000;
            timerThree.Tick += timerThree_Tick;
            // 
            // timerFour
            // 
            timerFour.Enabled = true;
            timerFour.Interval = 60000;
            timerFour.Tick += timerFour_Tick;
            // 
            // timerFive
            // 
            timerFive.Enabled = true;
            timerFive.Interval = 60000;
            timerFive.Tick += timerFive_Tick;
            // 
            // labelBoxOne
            // 
            labelBoxOne.AutoSize = true;
            labelBoxOne.Location = new Point(30, 267);
            labelBoxOne.Name = "labelBoxOne";
            labelBoxOne.Size = new Size(51, 15);
            labelBoxOne.TabIndex = 2;
            labelBoxOne.Text = "Box One";
            // 
            // labelBoxTwo
            // 
            labelBoxTwo.AutoSize = true;
            labelBoxTwo.Location = new Point(30, 292);
            labelBoxTwo.Name = "labelBoxTwo";
            labelBoxTwo.Size = new Size(51, 15);
            labelBoxTwo.TabIndex = 3;
            labelBoxTwo.Text = "Box Two";
            // 
            // labelBoxThree
            // 
            labelBoxThree.AutoSize = true;
            labelBoxThree.Location = new Point(30, 316);
            labelBoxThree.Name = "labelBoxThree";
            labelBoxThree.Size = new Size(59, 15);
            labelBoxThree.TabIndex = 4;
            labelBoxThree.Text = "Box Three";
            // 
            // labelBoxFour
            // 
            labelBoxFour.AutoSize = true;
            labelBoxFour.Location = new Point(30, 341);
            labelBoxFour.Name = "labelBoxFour";
            labelBoxFour.Size = new Size(53, 15);
            labelBoxFour.TabIndex = 5;
            labelBoxFour.Text = "Box Four";
            // 
            // labelBoxFive
            // 
            labelBoxFive.AutoSize = true;
            labelBoxFive.Location = new Point(30, 366);
            labelBoxFive.Name = "labelBoxFive";
            labelBoxFive.Size = new Size(50, 15);
            labelBoxFive.TabIndex = 6;
            labelBoxFive.Text = "Box Five";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 414);
            Controls.Add(labelBoxFive);
            Controls.Add(labelBoxFour);
            Controls.Add(labelBoxThree);
            Controls.Add(labelBoxTwo);
            Controls.Add(labelBoxOne);
            Controls.Add(buttonTest);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LeitnerSystems";
            FormClosing += Form1_FormClosing;
            Load += Form1_Resize;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
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
        private NotifyIcon notifyIconLS;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerOne;
        private ToolStripButton toolStripButtonTimers;
        private System.Windows.Forms.Timer timerTwo;
        private System.Windows.Forms.Timer timerThree;
        private System.Windows.Forms.Timer timerFour;
        private System.Windows.Forms.Timer timerFive;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButtonChart;
        private ToolStripButton toolStripButtonWordMovement;
        private ToolStripSeparator toolStripSeparator5;
        private Label labelBoxOne;
        private Label labelBoxTwo;
        private Label labelBoxThree;
        private Label labelBoxFour;
        private Label labelBoxFive;
    }
}
