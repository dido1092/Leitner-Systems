using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;

namespace Leitner_Systems
{
    public partial class FrmMoveToBoxOne : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        public FrmMoveToBoxOne()
        {
            InitializeComponent();
        }

        private void buttonLoadEnBgWords_Click(object sender, EventArgs e)
        {
            richTextBoxEnBgWords.Clear();

            var enBgWords = context.EnBgWords!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();

            var wordsFromBoxOne = context.BoxOnes!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();

            List<string> lsWords = new List<string>();
            List<string> lsWordsFromBoxOne = new List<string>();

            foreach (var word in enBgWords)
            {
                lsWords.Add(word.EnWord.Replace(" ", "") + "-" + word.BgWord.Replace(" ", ""));
            }

            foreach (var word in wordsFromBoxOne)
            {
                lsWordsFromBoxOne.Add(word.EnWord.Replace(" ", "") + "-" + word.BgWord.Replace(" ", ""));
            }

            foreach (var word in lsWords)
            {
                string wordEn = string.Empty;
                string wordBg = string.Empty;

                wordEn = word.Replace(" ", "");
                wordBg = word.Replace(" ", "");

                if (lsWordsFromBoxOne.Contains(word))
                {
                    richTextBoxEnBgWords.SelectionColor = Color.Red;
                }
                else
                {
                    richTextBoxEnBgWords.SelectionColor = Color.Black;
                }
                richTextBoxEnBgWords.AppendText($"{word}\n");
            }

            labelRows.Text = lsWords.Count.ToString();
        }

        private void buttonMoveToBoxOne_Click(object sender, EventArgs e)
        {
            string words = richTextBoxEnBgWords.SelectedText;

            string[] arrWords = words.Split("-");

            if (arrWords.Length == 2)
            {
                BoxOne boxOne = new BoxOne()
                {
                    EnWord = arrWords[0],
                    BgWord = arrWords[1],
                    InsertDate = DateTime.Now,
                };
                context.Add(boxOne);
                context.SaveChanges();

                MessageBox.Show("Done!");
            }
        }
    }
}
