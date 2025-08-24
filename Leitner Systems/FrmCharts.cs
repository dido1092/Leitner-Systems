using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Leitner_Systems
{
    public partial class FrmCharts : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();
        public FrmCharts()
        {
            InitializeComponent();
        }

        private void buttonLoadWordMovement_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dictWordsBoxes = new Dictionary<string, int>();

            Dictionary<string, DateTime> dictWordsDate = new Dictionary<string, DateTime>();

            chartBoxes.Series.Clear();
            chartDate.Series.Clear();

            string word = richTextBoxWords.SelectedText.ToUpper().Trim().Replace(" ", "");


            var getWord = context.WordMovements!.Select(w => new { w.Id, w.EnWord, w.BgWord, w.FromBox, w.ToBox, w.DisplayLanguage, w.Hint, w.InsertDate }).Where(w => w.EnWord == word).ToList();

            if (getWord! != null)
            {
                // ================ Dict Boxes =================

                foreach (var w in getWord)
                {
                    if (!dictWordsBoxes.ContainsKey(w.ToBox))
                    {
                        dictWordsBoxes.Add(w.ToBox, 1);
                    }
                    else
                    {
                        dictWordsBoxes[w.ToBox]++;
                    }
                }

                // ================= Dict Date =================

                foreach (var d in getWord.OrderBy(d => d.ToBox))
                {
                    if (!dictWordsDate.ContainsKey(d.ToBox))
                    {
                        dictWordsDate.Add(d.ToBox, d.InsertDate);
                    }
                    else
                    {
                        dictWordsDate[d.ToBox] = d.InsertDate;
                    }
                }

                // ================ Chart Boxes =================

                int allValue = 0;
                foreach (var w in dictWordsBoxes.OrderBy(w => w.Value))
                {
                    allValue += w.Value;

                    if (chartBoxes.Series.IsUniqueName(w!.Key.ToString()))
                    {
                        chartBoxes.Series.Add($"To: {w.Key}").Points.AddXY($"Time: ", w.Value);
                    }
                }
                chartBoxes.Series.Add($"All movement: {allValue}");

                // ================ Chart Date =================

                allValue = 0;
                foreach (var d in dictWordsDate.OrderBy(d => d.Value))
                {
                    allValue++;

                    if (chartDate.Series.IsUniqueName(d.Key!.ToString()))
                    {
                        chartDate.Series.Add($"To: {d.Key}").Points.AddXY($"Date: ", d.Value);
                    }
                }

                chartDate.Series.Add($"All times: {allValue}");

                labelWord.Text = $"{word}";
            }
            else
            {
                MessageBox.Show("Select a one 'En word'!");
            }
        }

        private void buttonLoadWords_Click(object sender, EventArgs e)
        {
            List<string> lsWords = new List<string>();

            var boxOneWords = context.BoxOnes!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var boxTwoWords = context.BoxTwos!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var boxThreeWords = context.BoxThrees!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var boxFourWords = context.BoxFours!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();
            var boxFiveWords = context.BoxFives!.Select(w => new { w.Id, w.EnWord, w.BgWord }).ToList();

            foreach (var word in boxOneWords)
            {
                lsWords.Add($"{word.EnWord} - {word.BgWord} - BoxOne");
            }
            foreach (var word in boxTwoWords)
            {
                lsWords.Add($"{word.EnWord} - {word.BgWord} - BoxTwo");
            }
            foreach (var word in boxThreeWords)
            {
                lsWords.Add($"{word.EnWord} - {word.BgWord} - BoxThree");
            }
            foreach (var word in boxFourWords)
            {
                lsWords.Add($"{word.EnWord} - {word.BgWord} - BoxFour");
            }
            foreach (var word in boxFiveWords)
            {
                lsWords.Add($"{word.EnWord} - {word.BgWord} - BoxFive");
            }

            richTextBoxWords.Text = string.Join("\n", lsWords.OrderBy(w => w));
        }
    }
}
