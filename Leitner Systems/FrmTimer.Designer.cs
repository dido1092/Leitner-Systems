
namespace Leitner_Systems
{
    partial class FrmTimer
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
            comboBoxOne = new ComboBox();
            comboBoxTwo = new ComboBox();
            comboBoxThree = new ComboBox();
            comboBoxFour = new ComboBox();
            comboBoxFive = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelInfo = new Label();
            buttonSet = new Button();
            comboBoxMHD = new ComboBox();
            label6 = new Label();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // comboBoxOne
            // 
            comboBoxOne.FormattingEnabled = true;
            comboBoxOne.Items.AddRange(new object[] { "1" });
            comboBoxOne.Location = new Point(182, 77);
            comboBoxOne.Name = "comboBoxOne";
            comboBoxOne.Size = new Size(121, 23);
            comboBoxOne.TabIndex = 0;
            // 
            // comboBoxTwo
            // 
            comboBoxTwo.FormattingEnabled = true;
            comboBoxTwo.Items.AddRange(new object[] { "2" });
            comboBoxTwo.Location = new Point(320, 77);
            comboBoxTwo.Name = "comboBoxTwo";
            comboBoxTwo.Size = new Size(121, 23);
            comboBoxTwo.TabIndex = 0;
            comboBoxTwo.SelectedIndexChanged += comboBoxTwo_SelectedIndexChanged;
            // 
            // comboBoxThree
            // 
            comboBoxThree.FormattingEnabled = true;
            comboBoxThree.Items.AddRange(new object[] { "4" });
            comboBoxThree.Location = new Point(456, 77);
            comboBoxThree.Name = "comboBoxThree";
            comboBoxThree.Size = new Size(121, 23);
            comboBoxThree.TabIndex = 0;
            // 
            // comboBoxFour
            // 
            comboBoxFour.FormattingEnabled = true;
            comboBoxFour.Items.AddRange(new object[] { "7" });
            comboBoxFour.Location = new Point(592, 77);
            comboBoxFour.Name = "comboBoxFour";
            comboBoxFour.Size = new Size(121, 23);
            comboBoxFour.TabIndex = 0;
            // 
            // comboBoxFive
            // 
            comboBoxFive.FormattingEnabled = true;
            comboBoxFive.Items.AddRange(new object[] { "15", "30" });
            comboBoxFive.Location = new Point(733, 77);
            comboBoxFive.Name = "comboBoxFive";
            comboBoxFive.Size = new Size(121, 23);
            comboBoxFive.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Box One";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 59);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Box Two";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 59);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Box Three";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(592, 59);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Box Four";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(733, 59);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 5;
            label5.Text = "Box Five";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(41, 203);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(28, 15);
            labelInfo.TabIndex = 6;
            labelInfo.Text = "Info";
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(1022, 59);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(121, 41);
            buttonSet.TabIndex = 7;
            buttonSet.Text = "SET";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // comboBoxMHD
            // 
            comboBoxMHD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMHD.FormattingEnabled = true;
            comboBoxMHD.Items.AddRange(new object[] { "Mins", "Hours", "Days" });
            comboBoxMHD.Location = new Point(884, 77);
            comboBoxMHD.Name = "comboBoxMHD";
            comboBoxMHD.Size = new Size(99, 23);
            comboBoxMHD.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(884, 59);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 9;
            label6.Text = "MHD";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(24, 59);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(101, 41);
            buttonLoad.TabIndex = 10;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // FrmTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 245);
            Controls.Add(buttonLoad);
            Controls.Add(label6);
            Controls.Add(comboBoxMHD);
            Controls.Add(buttonSet);
            Controls.Add(labelInfo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxFive);
            Controls.Add(comboBoxFour);
            Controls.Add(comboBoxThree);
            Controls.Add(comboBoxTwo);
            Controls.Add(comboBoxOne);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmTimer";
            Text = "FrmTimers";
            Load += FrmTimers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOne;
        private ComboBox comboBoxTwo;
        private ComboBox comboBoxThree;
        private ComboBox comboBoxFour;
        private ComboBox comboBoxFive;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelInfo;
        private Button buttonSet;
        private ComboBox comboBoxMHD;
        private Label label6;
        private Button buttonLoad;
    }
}