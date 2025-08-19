using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;

namespace Leitner_Systems
{
    public partial class FrmInsert : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        private string path = string.Empty;
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string enW = textBoxEnWord.Text.ToUpper();
            string bgW = textBoxBgWord.Text.ToUpper();

            if (enW.Length > 0 && bgW.Length > 0)
            {
                if (!checkBoxInBoxOne.Checked)
                {
                    EnBgWord enBgWord = new EnBgWord()
                    {
                        EnWord = enW,
                        BgWord = bgW,
                        DateTime = DateTime.Now,
                    };
                    context.Add(enBgWord);
                }
                else
                {
                    EnBgWord enBgWord = new EnBgWord()
                    {
                        EnWord = enW,
                        BgWord = bgW,
                        DateTime = DateTime.Now,
                    };
                    context.Add(enBgWord);

                    BoxOne boxOne = new BoxOne()
                    {
                        EnWord = enW,
                        BgWord = bgW,
                        InsertDate = DateTime.Now
                    };
                    context.BoxOnes!.Add(boxOne);
                }

                context.SaveChanges();

                MessageBox.Show("Inserted!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBgWord.Text = string.Empty;
            textBoxEnWord.Text = string.Empty;
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonInsertFromFile_Click(object sender, EventArgs e)
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
    }
}
