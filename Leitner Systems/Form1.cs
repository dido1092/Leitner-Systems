using Leitner_Systems.LeitnerSystemsDataModels;
using Leitner_Systems.LeitnerSystemsData;

using System.IO;

namespace Leitner_Systems
{
    public partial class Form1 : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonInsert_Click(object sender, EventArgs e)
        {
            FrmInsert insert = new FrmInsert();
            insert.Show();
        }

        private void toolStripButtonEnBgWords_Click(object sender, EventArgs e)
        {
            FrmTables enBgWordsTable = new FrmTables();
            enBgWordsTable.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonTables_Click(object sender, EventArgs e)
        {
            FrmTables frmTables = new FrmTables();
            frmTables.Show();
        }

        private void richTextBoxWords_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonMoveToBoxOne_Click(object sender, EventArgs e)
        {
            FrmMoveToBoxOne frmMoveToBoxOne = new FrmMoveToBoxOne();
            frmMoveToBoxOne.Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            FrmTest frmTest = new FrmTest();
            frmTest.Show();
        }
    }
}



