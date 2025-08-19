using Leitner_Systems.LeitnerSystemsDataModels;
using Leitner_Systems.LeitnerSystemsData;

using System.IO;

namespace Leitner_Systems
{
    public partial class Form1 : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        private string path = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            OpenFile();
            InsertEnBgWords();
            MessageBox.Show("Import Done!");
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }
        private void InsertEnBgWords()
        {
            string enWord = string.Empty;
            string bgWord = string.Empty;

            //HashSet<string> hsQA = new HashSet<string>();

            DateTime dateTimeNow = DateTime.Now;

            string[] lines = System.IO.File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                string getLine = lines[i];

                string[] arrWords = getLine.Split('-');

                if (getLine == "")
                {
                    continue;
                }

                if (getLine != "")
                {
                    enWord = arrWords[0].Trim().ToUpper();

                    bgWord = arrWords[1].Trim().ToUpper();

                    if (enWord != string.Empty && bgWord != string.Empty)
                    {
                        //hsQA.Add($"{enWord} {bgWord}");

                        //if (hsQA.Contains($"{enWord} {bgWord}"))
                        //{
                        EnBgWord enBgWord = new EnBgWord()
                        {
                            EnWord = enWord,
                            BgWord = bgWord,
                            DateTime = dateTimeNow
                        };
                        context.EnBgWords!.Add(enBgWord);
                        context.SaveChanges();
                    }
                    bgWord = string.Empty;
                    enWord = string.Empty;
                }
            }

        }

        private void toolStripButtonEnBgWords_Click(object sender, EventArgs e)
        {
            EnBgWordsTable enBgWordsTable = new EnBgWordsTable();
            enBgWordsTable.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



