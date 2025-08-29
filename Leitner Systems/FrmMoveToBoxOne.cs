using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;

namespace Leitner_Systems
{
    public partial class FrmMoveToBoxOne : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        //FormClosingEventArgs е = new FormClosingEventArgs(CloseReason.UserClosing, false);

        //Form1 form1 = new Form1();

        public FrmMoveToBoxOne()
        {
            InitializeComponent();
        }
        //=========================================================================
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        e.Cancel = true; // Prevent form from closing/disposing
        //        this.Hide();     // Just hide it instead
        //        return;
        //    }
        //    base.OnFormClosing(e);
        //}
        //=========================================================================
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

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive }).FirstOrDefault();

            double intervalMilisec = 0;

            intervalMilisec = SetTimers(intervalMilisec);

            intervalMilisec *= int.Parse(timers!.BoxOne);

            if (arrWords.Length == 2)
            {
                BoxOne boxOne = new BoxOne()
                {
                    EnWord = arrWords[0],
                    BgWord = arrWords[1],
                    InsertDate = DateTime.Now,
                    PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                };
                context.Add(boxOne);

                WordMovement wordMovement = new WordMovement()
                {
                    EnWord = arrWords[0],
                    BgWord = arrWords[1],
                    DisplayLanguage = "",
                    FromBox = "New word",
                    ToBox = "BoxOne",
                    Hint = false,
                    InsertDate = DateTime.Now
                };
                context.Add(wordMovement);

                context.SaveChanges();

                MessageBox.Show("Done!");
            }
        }

        private void FrmMoveToBoxOne_Load(object sender, EventArgs e)
        {

        }
        public double SetTimers(double interval)
        {
            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive, t.MHD }).FirstOrDefault();

            if (timers != null)
            {
                if (timers.MHD == "Mins")
                {
                    interval = 60000; // 1 minute
                }
                else if (timers.MHD == "Hours")
                {
                    interval = 3600000; // 1 hour
                }
                else if (timers.MHD == "Days")
                {
                    interval = 86400000; // 1 day
                }
            }

            return interval;
        }
    }
}
