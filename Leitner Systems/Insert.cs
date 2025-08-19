using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leitner_Systems
{
    public partial class Insert : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();
        public Insert()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string enW = textBoxEnWord.Text.ToUpper();
            string bgW = textBoxBgWord.Text.ToUpper();

            if (enW.Length > 0 && bgW.Length > 0)
            {
                EnBgWord enBgWord = new EnBgWord()
                {
                    EnWord = enW,
                    BgWord = bgW,
                    DateTime = DateTime.Now,
                };
                context.Add(enBgWord);

                context.SaveChanges();

                MessageBox.Show("Inserted!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBgWord.Text = string.Empty;
            textBoxEnWord.Text = string.Empty;
        }
    }
}
