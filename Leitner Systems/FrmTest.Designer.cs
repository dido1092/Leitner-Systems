namespace Leitner_Systems
{
    partial class FrmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            comboBoxLanguage = new ComboBox();
            label1 = new Label();
            buttonLoadTest = new Button();
            labelWord = new Label();
            textBoxWord = new TextBox();
            buttonCheckWord = new Button();
            labelTimers = new Label();
            labelInfo = new Label();
            pictureBoxSpeech = new PictureBox();
            comboBoxBoxes = new ComboBox();
            labelBoxes = new Label();
            progressBarWords = new ProgressBar();
            labelWordWord = new Label();
            buttonHint = new Button();
            labelNumWords = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpeech).BeginInit();
            SuspendLayout();
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] { "EN", "BG" });
            comboBoxLanguage.Location = new Point(22, 47);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(59, 23);
            comboBoxLanguage.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Language";
            // 
            // buttonLoadTest
            // 
            buttonLoadTest.Location = new Point(220, 47);
            buttonLoadTest.Name = "buttonLoadTest";
            buttonLoadTest.Size = new Size(96, 23);
            buttonLoadTest.TabIndex = 2;
            buttonLoadTest.Text = "Load Test";
            buttonLoadTest.UseVisualStyleBackColor = true;
            buttonLoadTest.Click += buttonLoadTest_Click;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWord.Location = new Point(196, 95);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(111, 47);
            labelWord.TabIndex = 3;
            labelWord.Text = "Word";
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(196, 177);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(244, 23);
            textBoxWord.TabIndex = 4;
            // 
            // buttonCheckWord
            // 
            buttonCheckWord.Location = new Point(458, 177);
            buttonCheckWord.Name = "buttonCheckWord";
            buttonCheckWord.Size = new Size(84, 23);
            buttonCheckWord.TabIndex = 5;
            buttonCheckWord.Text = "Check";
            buttonCheckWord.UseVisualStyleBackColor = true;
            buttonCheckWord.Click += buttonCheckWord_Click;
            // 
            // labelTimers
            // 
            labelTimers.AutoSize = true;
            labelTimers.Location = new Point(22, 400);
            labelTimers.Name = "labelTimers";
            labelTimers.Size = new Size(46, 15);
            labelTimers.TabIndex = 6;
            labelTimers.Text = "Timers:";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(196, 233);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(31, 15);
            labelInfo.TabIndex = 7;
            labelInfo.Text = "Info:";
            // 
            // pictureBoxSpeech
            // 
            pictureBoxSpeech.Image = (Image)resources.GetObject("pictureBoxSpeech.Image");
            pictureBoxSpeech.InitialImage = (Image)resources.GetObject("pictureBoxSpeech.InitialImage");
            pictureBoxSpeech.Location = new Point(563, 171);
            pictureBoxSpeech.Name = "pictureBoxSpeech";
            pictureBoxSpeech.Size = new Size(27, 29);
            pictureBoxSpeech.TabIndex = 8;
            pictureBoxSpeech.TabStop = false;
            pictureBoxSpeech.Click += pictureBox1_Click;
            // 
            // comboBoxBoxes
            // 
            comboBoxBoxes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBoxes.FormattingEnabled = true;
            comboBoxBoxes.Items.AddRange(new object[] { "BoxOne", "BoxTwo", "BoxThree", "BoxFour", "BoxFive" });
            comboBoxBoxes.Location = new Point(106, 47);
            comboBoxBoxes.Name = "comboBoxBoxes";
            comboBoxBoxes.Size = new Size(108, 23);
            comboBoxBoxes.TabIndex = 9;
            // 
            // labelBoxes
            // 
            labelBoxes.AutoSize = true;
            labelBoxes.Location = new Point(106, 29);
            labelBoxes.Name = "labelBoxes";
            labelBoxes.Size = new Size(37, 15);
            labelBoxes.TabIndex = 10;
            labelBoxes.Text = "Boxes";
            // 
            // progressBarWords
            // 
            progressBarWords.Location = new Point(196, 206);
            progressBarWords.Name = "progressBarWords";
            progressBarWords.Size = new Size(244, 12);
            progressBarWords.TabIndex = 11;
            // 
            // labelWordWord
            // 
            labelWordWord.AutoSize = true;
            labelWordWord.Location = new Point(196, 159);
            labelWordWord.Name = "labelWordWord";
            labelWordWord.Size = new Size(72, 15);
            labelWordWord.TabIndex = 12;
            labelWordWord.Text = "word - word";
            // 
            // buttonHint
            // 
            buttonHint.Enabled = false;
            buttonHint.Location = new Point(631, 46);
            buttonHint.Name = "buttonHint";
            buttonHint.Size = new Size(75, 23);
            buttonHint.TabIndex = 13;
            buttonHint.Text = "Hint";
            buttonHint.UseVisualStyleBackColor = true;
            buttonHint.Click += buttonHint_Click;
            // 
            // labelNumWords
            // 
            labelNumWords.AutoSize = true;
            labelNumWords.Location = new Point(22, 95);
            labelNumWords.Name = "labelNumWords";
            labelNumWords.Size = new Size(44, 15);
            labelNumWords.TabIndex = 14;
            labelNumWords.Text = "Words:";
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 424);
            Controls.Add(labelNumWords);
            Controls.Add(buttonHint);
            Controls.Add(labelWordWord);
            Controls.Add(progressBarWords);
            Controls.Add(labelBoxes);
            Controls.Add(comboBoxBoxes);
            Controls.Add(pictureBoxSpeech);
            Controls.Add(labelInfo);
            Controls.Add(labelTimers);
            Controls.Add(buttonCheckWord);
            Controls.Add(textBoxWord);
            Controls.Add(labelWord);
            Controls.Add(buttonLoadTest);
            Controls.Add(label1);
            Controls.Add(comboBoxLanguage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTest";
            Load += FrmTest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSpeech).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxLanguage;
        private Label label1;
        private Button buttonLoadTest;
        private Label labelWord;
        private TextBox textBoxWord;
        private Button buttonCheckWord;
        private Label labelTimers;
        private Label labelInfo;
        private PictureBox pictureBoxSpeech;
        private ComboBox comboBoxBoxes;
        private Label labelBoxes;
        private ProgressBar progressBarWords;
        private Label labelWordWord;
        private Button buttonHint;
        private Label labelNumWords;
    }
}