using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;
using System.Speech.Synthesis;


namespace Leitner_Systems
{
    public partial class FrmTest : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        private List<int> lsIdsBoxOne = new List<int>();
        private List<int> lsIdsBoxTwo = new List<int>();
        private List<int> lsIdsBoxThree = new List<int>();
        private List<int> lsIdsBoxFour = new List<int>();
        private List<int> lsIdsBoxFive = new List<int>();

        private int index = 0;
        private List<int> lsIds = new List<int>();
        private List<Words> lsWords = new List<Words>();
        public FrmTest()
        {
            InitializeComponent();
        }

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

        private void buttonCheckWord_Click(object sender, EventArgs e)
        {
            string goToBox = string.Empty;
            string currentWordBg = string.Empty;
            string currentWordEn = string.Empty;

            string word = labelWord.Text;
            string writingWord = textBoxWord.Text.ToUpper();

            if (comboBoxLanguage.Text == "EN" && lsWords.Count > index)
            {
                var getWord = lsWords.Select(i => new { i.Id, i.BgWord, i.EnWord }).Where(i => i.Id == lsIds[index]).FirstOrDefault()!;

                currentWordBg = getWord.BgWord.ToUpper().Replace(" ", "");
                currentWordEn = getWord.EnWord.ToUpper().Replace(" ", "");

                if (writingWord == currentWordBg)
                {
                    if (comboBoxBoxes.Text == "BoxOne")
                    {
                        var wordForDelete = context.BoxOnes!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxOnes!.Remove(wordForDelete!);
                        }

                        BoxTwo boxTwo = new BoxTwo()
                        {
                            EnWord = word,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };

                        context.Add(boxTwo);

                        goToBox = "BoxTwo";
                    }
                    else if (comboBoxBoxes.Text == "BoxTwo")
                    {
                        var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxTwos!.Remove(wordForDelete!);
                        }

                        BoxThree boxThree = new BoxThree()
                        {
                            EnWord = word,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };
                        context.Add(boxThree);

                        goToBox = "BoxThree";
                    }
                    else if (comboBoxBoxes.Text == "BoxThree")
                    {
                        var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxThrees!.Remove(wordForDelete!);
                        }

                        BoxFour boxFour = new BoxFour()
                        {
                            EnWord = word,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };
                        context.Add(boxFour);

                        goToBox = "BoxFour";
                    }
                    else if (comboBoxBoxes.Text == "BoxFour")
                    {
                        var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxFours!.Remove(wordForDelete!);
                        }

                        BoxFive boxFive = new BoxFive()
                        {
                            EnWord = word,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };
                        context.Add(boxFive);

                        goToBox = "BoxFive";
                    }
                }
                else // If writing word is NOT correct!
                {
                    if (comboBoxBoxes.Text == "BoxOne")
                    {
                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxTwo")
                    {
                        var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxTwos!.Remove(wordForDelete!);

                            AddToBoxOne(word, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxThree")
                    {
                        var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxThrees!.Remove(wordForDelete!);

                            AddToBoxOne(word, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxFour")
                    {
                        var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxFours!.Remove(wordForDelete!);

                            AddToBoxOne(word, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxFive")
                    {
                        var wordForDelete = context.BoxFives!.FirstOrDefault(w => w.BgWord.Replace(" ", "") == currentWordBg);

                        if (wordForDelete != null)
                        {
                            context.BoxFives!.Remove(wordForDelete!);

                            AddToBoxOne(word, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                }

            }
            else if (comboBoxLanguage.Text == "BG" && lsWords.Count > index)
            {
                var getWord = lsWords.Select(i => new { i.Id, i.EnWord, i.BgWord }).Where(i => i.Id == lsIds[index]).FirstOrDefault()!;

                currentWordBg = getWord.BgWord.ToUpper().Replace(" ", "");
                currentWordEn = getWord.EnWord.ToUpper().Replace(" ", "");

                if (writingWord == currentWordEn)
                {
                    if (comboBoxBoxes.Text == "BoxOne")
                    {
                        var wordForDelete = context.BoxOnes!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxOnes!.Remove(wordForDelete!);
                        }

                        BoxTwo boxTwo = new BoxTwo()
                        {
                            EnWord = currentWordEn,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };

                        context.Add(boxTwo);

                        goToBox = "BoxTwo";
                    }
                    else if (comboBoxBoxes.Text == "BoxTwo")
                    {
                        var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxTwos!.Remove(wordForDelete!);
                        }

                        BoxThree boxThree = new BoxThree()
                        {
                            EnWord = currentWordEn,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };
                        context.Add(boxThree);

                        goToBox = "BoxThree";
                    }
                    else if (comboBoxBoxes.Text == "BoxThree")
                    {
                        var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxThrees!.Remove(wordForDelete!);
                        }

                        BoxFour boxFour = new BoxFour()
                        {
                            EnWord = currentWordEn,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };
                        context.Add(boxFour);

                        goToBox = "BoxFour";
                    }
                    else if (comboBoxBoxes.Text == "BoxFour")
                    {
                        var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxFours!.Remove(wordForDelete!);
                        }

                        BoxFive boxFive = new BoxFive()
                        {
                            EnWord = currentWordEn,
                            BgWord = currentWordBg,
                            InsertDate = DateTime.Now
                        };
                        context.Add(boxFive);

                        goToBox = "BoxFive";
                    }
                }
                else // If writing word is NOT correct!
                {
                    if (comboBoxBoxes.Text == "BoxOne")
                    {
                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxTwo")
                    {
                        var wordForDelete = context.BoxTwos!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxTwos!.Remove(wordForDelete!);

                            AddToBoxOne(currentWordEn, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxThree")
                    {
                        var wordForDelete = context.BoxThrees!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxThrees!.Remove(wordForDelete!);

                            AddToBoxOne(currentWordEn, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxFour")
                    {
                        var wordForDelete = context.BoxFours!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxFours!.Remove(wordForDelete!);

                            AddToBoxOne(currentWordEn, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                    else if (comboBoxBoxes.Text == "BoxFive")
                    {
                        var wordForDelete = context.BoxFives!.FirstOrDefault(w => w.EnWord.Replace(" ", "") == currentWordEn);

                        if (wordForDelete != null)
                        {
                            context.BoxFives!.Remove(wordForDelete!);

                            AddToBoxOne(currentWordEn, currentWordBg);
                        }

                        goToBox = "BoxOne";
                    }
                }
            }
            // --------------------------------------------------------------------------------------------------------------------

            string nextWordBg = string.Empty;
            string nextWordEn = string.Empty;

            index++;
            context.SaveChanges();

            if (lsIds.Count > index)
            {
                var getNextWord = lsWords.Select(i => new { i.Id, i.EnWord, i.BgWord }).Where(i => i.Id == lsIds[index]).FirstOrDefault()!;

                if (comboBoxLanguage.Text == "EN")
                {
                    nextWordEn = getNextWord.EnWord.ToUpper().Replace(" ", "");

                    labelWord.Text = nextWordEn;
                }
                else if (comboBoxLanguage.Text == "BG")
                {
                    nextWordBg = getNextWord.BgWord.ToUpper().Replace(" ", "");

                    labelWord.Text = nextWordBg;
                }
            }
            else
            {
                lsIds.Clear();
                lsWords.Clear();

                labelWord.Text = string.Empty;
                textBoxWord.Text = string.Empty;

                index = 0;

                return;
            }

            labelInfo.Text = $"Word go to box: {goToBox}";

            textBoxWord.Text = string.Empty;

            textBoxWord.Focus();
        }
        private void AddToBoxOne(string word, string currentWord)
        {
            BoxOne boxOne = new BoxOne()
            {
                EnWord = word,
                BgWord = currentWord,
                InsertDate = DateTime.Now
            };

            context.Add(boxOne);
            //context.SaveChanges();
        }

        private void buttonLoadTest_Click(object sender, EventArgs e)
        {
            lsIdsBoxOne = new List<int>();
            lsIdsBoxTwo = new List<int>();
            lsIdsBoxThree = new List<int>();
            lsIdsBoxFour = new List<int>();
            lsIdsBoxFive = new List<int>();

            lsWords = new List<Words>();

            var wordsBoxOne = context.BoxOnes!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var wordsBoxTwo = context.BoxTwos!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var wordsBoxThree = context.BoxThrees!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var wordsBoxFour = context.BoxFours!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var wordsBoxFive = context.BoxFives!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();

            wordsBoxOne = wordsBoxOne.OrderBy(w => w.Id).ToList();

            if (comboBoxBoxes.Text == "BoxOne")
            {
                foreach (var w in wordsBoxOne.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord);
                }
            }
            else if (comboBoxBoxes.Text == "BoxTwo")
            {
                foreach (var w in wordsBoxTwo.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord);
                }
            }
            else if (comboBoxBoxes.Text == "BoxThree")
            {
                foreach (var w in wordsBoxThree.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord);
                }
            }
            else if (comboBoxBoxes.Text == "BoxFour")
            {
                foreach (var w in wordsBoxFour.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord);
                }
            }
            else if (comboBoxBoxes.Text == "BoxFive")
            {
                foreach (var w in wordsBoxFive.OrderBy(w => w.Id))
                {
                    lsIds.Add(w.Id);

                    AddWords(w.Id, w.EnWord, w.BgWord);
                }
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
                }
                else if (comboBoxLanguage.Text == "BG")
                {
                    firstWord = w.BgWord;
                }

                break;
            }

            labelWord.Text = firstWord.ToString();

        }

        private void AddWords(int id, string enW, string bgW)
        {
            Words words = new Words()
            {
                Id = id,
                EnWord = enW,
                BgWord = bgW
            };
            lsWords.Add(words);
        }
    }
}
