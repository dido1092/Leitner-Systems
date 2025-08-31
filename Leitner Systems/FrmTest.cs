using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;
using System.Speech.Synthesis;


namespace Leitner_Systems
{
    public partial class FrmTest : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        FormClosingEventArgs е = new FormClosingEventArgs(CloseReason.UserClosing, false);

        //private List<int> lsIdsBoxOne = new List<int>();
        //private List<int> lsIdsBoxTwo = new List<int>();
        //private List<int> lsIdsBoxThree = new List<int>();
        //private List<int> lsIdsBoxFour = new List<int>();
        //private List<int> lsIdsBoxFive = new List<int>();

        private int index = 0;
        private List<int> lsIds = new List<int>();
        private List<Words> lsWords = new List<Words>();
        private bool isHint = false;
        private int numWords = 0;
        public FrmTest()
        {
            OnFormClosing(е);
            InitializeComponent();
        }
        //=========================================================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Prevent form from closing/disposing
                this.Hide();     // Just hide it instead
                return;
            }
            base.OnFormClosing(e);
        }
        //=========================================================================
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.Text == "EN")
            {
                string word = labelWord.Text;
                ReadText(word);
            }
        }
        private void ReadText(string word)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.SpeakAsync(word);
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
        private void buttonCheckWord_Click(object sender, EventArgs e)
        {
            string goToBox = string.Empty;
            string currentWordBg = string.Empty;
            string currentWordEn = string.Empty;

            string word = labelWord.Text;
            string writingWord = textBoxWord.Text.ToUpper();
            string[] arrWritingWords = writingWord.Split("-");

            //Form1 form1 = new Form1();
            double intervalMilisec = 0;
            intervalMilisec = SetTimers(intervalMilisec);

            if (arrWritingWords.Count() == 2)
            {
                var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive }).FirstOrDefault();

                if (comboBoxLanguage.Text == "EN" && lsWords.Count > index && textBoxWord.Text != string.Empty)
                {
                    var getWord = lsWords.Select(i => new { i.Id, i.BgWord, i.EnWord, i.PerformanceTime }).Where(i => i.Id == lsIds[index] && i.PerformanceTime <= DateTime.Now).FirstOrDefault()!;

                    currentWordBg = getWord.BgWord.ToUpper().TrimEnd();
                    currentWordEn = getWord.EnWord.ToUpper().TrimEnd();

                    if (arrWritingWords[0] == currentWordBg && arrWritingWords[1] == currentWordEn)
                    {
                        if (comboBoxBoxes.Text == "BoxOne")
                        {
                            var wordForDelete = context.BoxOnes!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxOnes!.Remove(wordForDelete!);
                            }

                            intervalMilisec *= int.Parse(timers!.BoxTwo);

                            BoxTwo boxTwo = new BoxTwo()
                            {
                                EnWord = word,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };

                            context.Add(boxTwo);

                            goToBox = "Two";
                        }
                        else if (comboBoxBoxes.Text == "BoxTwo")
                        {
                            var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxTwos!.Remove(wordForDelete!);
                            }
                            intervalMilisec *= int.Parse(timers!.BoxThree);

                            BoxThree boxThree = new BoxThree()
                            {
                                EnWord = word,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxThree);

                            goToBox = "Three";
                        }
                        else if (comboBoxBoxes.Text == "BoxThree")
                        {
                            var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxThrees!.Remove(wordForDelete!);
                            }
                            intervalMilisec *= int.Parse(timers!.BoxFour);

                            BoxFour boxFour = new BoxFour()
                            {
                                EnWord = word,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxFour);

                            goToBox = "Four";
                        }
                        else if (comboBoxBoxes.Text == "BoxFour")
                        {
                            var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxFours!.Remove(wordForDelete!);
                            }
                            intervalMilisec *= int.Parse(timers!.BoxFive);

                            BoxFive boxFive = new BoxFive()
                            {
                                EnWord = word,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxFive);

                            goToBox = "Five";
                        }
                        else if (comboBoxBoxes.Text == "BoxFive")
                        {
                            var wordForDelete = context.BoxFives!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxFives!.Remove(wordForDelete!);
                            }
                            intervalMilisec *= int.Parse(timers!.BoxFive);

                            BoxFive boxFive = new BoxFive()
                            {
                                EnWord = word,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxFive);

                            goToBox = "Five";
                        }
                    }
                    else // If writing word is NOT correct!
                    {
                        if (comboBoxBoxes.Text == "BoxOne")
                        {
                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxTwo")
                        {
                            var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxTwos!.Remove(wordForDelete!);

                                AddToBoxOne(word, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxThree")
                        {
                            var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxThrees!.Remove(wordForDelete!);

                                AddToBoxOne(word, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxFour")
                        {
                            var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxFours!.Remove(wordForDelete!);

                                AddToBoxOne(word, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxFive")
                        {
                            var wordForDelete = context.BoxFives!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                            if (wordForDelete != null)
                            {
                                context.BoxFives!.Remove(wordForDelete!);

                                AddToBoxOne(word, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                    }

                }
                else if (comboBoxLanguage.Text == "BG" && lsWords.Count > index && textBoxWord.Text != string.Empty)
                {
                    var getWord = lsWords.Select(i => new { i.Id, i.EnWord, i.BgWord }).Where(i => i.Id == lsIds[index]).FirstOrDefault()!;

                    currentWordBg = getWord.BgWord.ToUpper().TrimEnd();
                    currentWordEn = getWord.EnWord.ToUpper().TrimEnd();

                    if (arrWritingWords[0] == currentWordEn && arrWritingWords[1] == currentWordBg)
                    {
                        if (comboBoxBoxes.Text == "BoxOne")
                        {
                            var wordForDelete = context.BoxOnes!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxOnes!.Remove(wordForDelete!);
                            }
                            intervalMilisec *= int.Parse(timers!.BoxTwo);

                            BoxTwo boxTwo = new BoxTwo()
                            {
                                EnWord = currentWordEn,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };

                            context.Add(boxTwo);

                            goToBox = "Two";
                        }
                        else if (comboBoxBoxes.Text == "BoxTwo")
                        {
                            var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxTwos!.Remove(wordForDelete!);
                            }

                            intervalMilisec *= int.Parse(timers!.BoxThree);

                            BoxThree boxThree = new BoxThree()
                            {
                                EnWord = currentWordEn,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxThree);

                            goToBox = "Three";
                        }
                        else if (comboBoxBoxes.Text == "BoxThree")
                        {
                            var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxThrees!.Remove(wordForDelete!);
                            }

                            intervalMilisec *= int.Parse(timers!.BoxFour);

                            BoxFour boxFour = new BoxFour()
                            {
                                EnWord = currentWordEn,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxFour);

                            goToBox = "Four";
                        }
                        else if (comboBoxBoxes.Text == "BoxFour")
                        {
                            var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxFours!.Remove(wordForDelete!);
                            }

                            intervalMilisec *= int.Parse(timers!.BoxFive);

                            BoxFive boxFive = new BoxFive()
                            {
                                EnWord = currentWordEn,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxFive);

                            goToBox = "Five";
                        }
                        else if (comboBoxBoxes.Text == "BoxFive")
                        {
                            var wordForDelete = context.BoxFives!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxFives!.Remove(wordForDelete!);
                            }

                            intervalMilisec *= int.Parse(timers!.BoxFive);

                            BoxFive boxFive = new BoxFive()
                            {
                                EnWord = currentWordEn,
                                BgWord = currentWordBg,
                                InsertDate = DateTime.Now,
                                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                            };
                            context.Add(boxFive);

                            goToBox = "Five";
                        }
                    }
                    else // If writing word is NOT correct!
                    {
                        if (comboBoxBoxes.Text == "BoxOne")
                        {
                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxTwo")
                        {
                            var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxTwos!.Remove(wordForDelete!);

                                AddToBoxOne(currentWordEn, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxThree")
                        {
                            var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxThrees!.Remove(wordForDelete!);

                                AddToBoxOne(currentWordEn, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxFour")
                        {
                            var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxFours!.Remove(wordForDelete!);

                                AddToBoxOne(currentWordEn, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                        else if (comboBoxBoxes.Text == "BoxFive")
                        {
                            var wordForDelete = context.BoxFives!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                            if (wordForDelete != null)
                            {
                                context.BoxFives!.Remove(wordForDelete!);

                                AddToBoxOne(currentWordEn, currentWordBg, intervalMilisec);
                            }

                            goToBox = "One";
                        }
                    }
                }

                if (currentWordEn != string.Empty && currentWordBg != string.Empty && goToBox != string.Empty)
                {
                    WordMovement wordMovement = new WordMovement()
                    {
                        EnWord = currentWordEn,
                        BgWord = currentWordBg,
                        DisplayLanguage = comboBoxLanguage.Text,
                        FromBox = comboBoxBoxes.Text,
                        ToBox = "Box" + goToBox,
                        Hint = isHint,
                        InsertDate = DateTime.Now
                    };
                    context.Add(wordMovement);
                }

                isHint = false;

                // --------------------------------------------------------------------------------------------------------------------
                if (textBoxWord.Text != string.Empty)
                {
                    string nextWordBg = string.Empty;
                    string nextWordEn = string.Empty;

                    index++;
                    context.SaveChanges();

                    if (lsIds.Count > index)
                    {
                        var getNextWord = lsWords.Select(i => new { i.Id, i.EnWord, i.BgWord }).Where(i => i.Id == lsIds[index]).FirstOrDefault()!;

                        if (comboBoxLanguage.Text == "EN")
                        {
                            nextWordEn = getNextWord.EnWord.ToUpper();

                            labelWord.Text = nextWordEn;
                        }
                        else if (comboBoxLanguage.Text == "BG")
                        {
                            nextWordBg = getNextWord.BgWord.ToUpper();

                            labelWord.Text = nextWordBg;
                        }

                        if (progressBarWords.Value < progressBarWords.Maximum)
                        {
                            progressBarWords.Value++;

                        }

                        labelNumWords.Text = $"Words: {numWords--}";


                        labelInfo.Text = $"Word go to box: {goToBox}";
                    }
                    else
                    {
                        lsIds.Clear();
                        lsWords.Clear();

                        labelWord.Text = string.Empty;
                        textBoxWord.Text = string.Empty;

                        index = 0;

                        labelInfo.Text = $"Word go to box: {goToBox}";
                        labelNumWords.Text = $"Words: {numWords--}";

                        LoadTest();

                        return;
                    }

                    textBoxWord.Text = string.Empty;

                    textBoxWord.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please write the word in the format: Word - Word");
            }
        }

        private void AddToBoxOne(string word, string currentWord, double intervalMilisec)
        {
            BoxOne boxOne = new BoxOne()
            {
                EnWord = word,
                BgWord = currentWord,
                InsertDate = DateTime.Now,
                PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
            };

            context.Add(boxOne);
        }

        private void buttonLoadTest_Click(object sender, EventArgs e)
        {
            LoadTest();
        }

        public void LoadTest()
        {
            lsWords = new List<Words>();

            var wordsBoxOne = context.BoxOnes!.Select(w => new { w.Id, w.EnWord, w.BgWord, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).ToList();
            var wordsBoxTwo = context.BoxTwos!.Select(w => new { w.Id, w.EnWord, w.BgWord, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).ToList();
            var wordsBoxThree = context.BoxThrees!.Select(w => new { w.Id, w.EnWord, w.BgWord, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).ToList();
            var wordsBoxFour = context.BoxFours!.Select(w => new { w.Id, w.EnWord, w.BgWord, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).ToList();
            var wordsBoxFive = context.BoxFives!.Select(w => new { w.Id, w.EnWord, w.BgWord, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).ToList();

            wordsBoxOne = wordsBoxOne.OrderBy(w => w.Id).ToList();

            if (comboBoxBoxes.Text == "BoxOne")
            {
                foreach (var w in wordsBoxOne.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord, w.PerformanceTime);
                }
                buttonHint.Enabled = true;

                numWords = wordsBoxOne.Count;
            }
            else if (comboBoxBoxes.Text == "BoxTwo")
            {
                foreach (var w in wordsBoxTwo.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord, w.PerformanceTime);
                }
                buttonHint.Enabled = false;

                numWords = wordsBoxTwo.Count;
            }
            else if (comboBoxBoxes.Text == "BoxThree")
            {
                foreach (var w in wordsBoxThree.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord, w.PerformanceTime);
                }
                buttonHint.Enabled = false;

                numWords = wordsBoxThree.Count;
            }
            else if (comboBoxBoxes.Text == "BoxFour")
            {
                foreach (var w in wordsBoxFour.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord, w.PerformanceTime);
                }
                buttonHint.Enabled = false;

                numWords = wordsBoxFour.Count;
            }
            else if (comboBoxBoxes.Text == "BoxFive")
            {
                foreach (var w in wordsBoxFive.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord, w.PerformanceTime);
                }
                buttonHint.Enabled = false;

                numWords = wordsBoxFive.Count;
            }
            else
            {
                MessageBox.Show("Please select a box!");
            }

            string firstWord = string.Empty;

            foreach (var w in lsWords.OrderBy(w => w.Id))
            {
                if (comboBoxLanguage.Text == "EN")
                {
                    firstWord = w.EnWord;

                    labelWordWord.Text = "BgWord - EnWord";
                }
                else if (comboBoxLanguage.Text == "BG")
                {
                    firstWord = w.BgWord;

                    labelWordWord.Text = "EnWord - BgWord";
                }

                break;
            }

            progressBarWords.Value = 0;
            progressBarWords.Maximum = lsWords.Count();
            progressBarWords.Minimum = 0;

            if (progressBarWords.Value < progressBarWords.Maximum)
            {
                progressBarWords.Value++;

            }

            isHint = false;

            labelWord.Text = firstWord.ToString();
            labelNumWords.Text = $"Words: {numWords--}";
        }

        private List<Words> AddWords(int id, string enW, string bgW, DateTime PerformanceTime)
        {
            Words words = new Words()
            {
                Id = id,
                EnWord = enW,
                BgWord = bgW,
                PerformanceTime = PerformanceTime
            };

            lsWords.Add(words);

            return lsWords;
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive, t.MHD }).FirstOrDefault();

            string? mhd = timers!.MHD;

            //labelTimers.Text = $"BoxOne: '{timers!.BoxOne}' / BoxTwo: '{timers!.BoxTwo}' / BoxThree: '{timers!.BoxThree}' / BoxFour: '{timers!.BoxFour}' / BoxFive: '{timers!.BoxFive}' In: {mhd}";
        }

        public void LoadBox(string boxTable)
        {
            comboBoxBoxes.Text = boxTable;
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            string word = labelWord.Text;

            if (comboBoxLanguage.Text == "EN")
            {
                var getWords = lsWords.Select(i => new { i.Id, i.EnWord, i.BgWord }).Where(i => i.EnWord == word).FirstOrDefault()!;

                MessageBox.Show(getWords.BgWord);
            }
            else if (comboBoxLanguage.Text == "BG")
            {
                var getWords = lsWords.Select(i => new { i.Id, i.EnWord, i.BgWord }).Where(i => i.BgWord == word).FirstOrDefault()!;

                MessageBox.Show(getWords.EnWord);
            }
            else
            {
                MessageBox.Show("Please select a language!");
            }

            isHint = true;
        }
    }
}
