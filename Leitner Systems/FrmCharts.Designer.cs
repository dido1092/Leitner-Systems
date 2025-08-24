namespace Leitner_Systems
{
    partial class FrmCharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            wordMovementBindingSource = new BindingSource(components);
            buttonLoadWordMovement = new Button();
            chartBoxes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            richTextBoxWords = new RichTextBox();
            buttonLoadWords = new Button();
            chartDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelWord = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBoxes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDate).BeginInit();
            SuspendLayout();
            // 
            // wordMovementBindingSource
            // 
            wordMovementBindingSource.DataSource = typeof(LeitnerSystemsDataModels.WordMovement);
            // 
            // buttonLoadWordMovement
            // 
            buttonLoadWordMovement.Location = new Point(372, 44);
            buttonLoadWordMovement.Name = "buttonLoadWordMovement";
            buttonLoadWordMovement.Size = new Size(95, 43);
            buttonLoadWordMovement.TabIndex = 1;
            buttonLoadWordMovement.Text = "View word movement";
            buttonLoadWordMovement.UseVisualStyleBackColor = true;
            buttonLoadWordMovement.Click += buttonLoadWordMovement_Click;
            // 
            // chartBoxes
            // 
            chartArea1.Name = "ChartArea1";
            chartBoxes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBoxes.Legends.Add(legend1);
            chartBoxes.Location = new Point(372, 93);
            chartBoxes.Name = "chartBoxes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBoxes.Series.Add(series1);
            chartBoxes.Size = new Size(300, 300);
            chartBoxes.TabIndex = 2;
            chartBoxes.Text = "Boxes";
            // 
            // richTextBoxWords
            // 
            richTextBoxWords.Location = new Point(30, 93);
            richTextBoxWords.Name = "richTextBoxWords";
            richTextBoxWords.Size = new Size(293, 300);
            richTextBoxWords.TabIndex = 3;
            richTextBoxWords.Text = "";
            // 
            // buttonLoadWords
            // 
            buttonLoadWords.Location = new Point(30, 58);
            buttonLoadWords.Name = "buttonLoadWords";
            buttonLoadWords.Size = new Size(93, 29);
            buttonLoadWords.TabIndex = 4;
            buttonLoadWords.Text = "Load words";
            buttonLoadWords.UseVisualStyleBackColor = true;
            buttonLoadWords.Click += buttonLoadWords_Click;
            // 
            // chartDate
            // 
            chartArea2.Name = "ChartArea1";
            chartDate.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDate.Legends.Add(legend2);
            chartDate.Location = new Point(711, 93);
            chartDate.Name = "chartDate";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDate.Series.Add(series2);
            chartDate.Size = new Size(422, 300);
            chartDate.TabIndex = 5;
            chartDate.Text = "Date";
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWord.Location = new Point(608, 24);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(90, 32);
            labelWord.TabIndex = 6;
            labelWord.Text = "WORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 72);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 7;
            label1.Text = "Show last records after repeats";
            // 
            // FrmCharts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 739);
            Controls.Add(label1);
            Controls.Add(labelWord);
            Controls.Add(chartDate);
            Controls.Add(buttonLoadWords);
            Controls.Add(richTextBoxWords);
            Controls.Add(chartBoxes);
            Controls.Add(buttonLoadWordMovement);
            Name = "FrmCharts";
            Text = "FrmCharts";
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartBoxes).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource wordMovementBindingSource;
        private Button buttonLoadWordMovement;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBoxes;
        private RichTextBox richTextBoxWords;
        private Button buttonLoadWords;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDate;
        private Label labelWord;
        private Label label1;
    }
}