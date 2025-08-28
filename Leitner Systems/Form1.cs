using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;
using Microsoft.Win32;
using System;
using System.IO;
using System.Threading;

namespace Leitner_Systems
{
    public partial class Form1 : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        FrmTest frmTest = new FrmTest();
        public Form1()
        {
            InitializeComponent();

            Thread thrDateTimeNow = new Thread(SetStartup);
            thrDateTimeNow.IsBackground = true;
            thrDateTimeNow.Start();
        }

        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)!;

            rk.SetValue("LeitnerSystems", Application.ExecutablePath);
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
            //Form1_Resize(sender, e);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                MinimzedTray();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {

                MaxmizedFromTray();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIconLS.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
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

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIconLS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIconLS.ContextMenuStrip = contextMenuStrip1;

            this.Show();

            MaxmizedFromTray();
        }
        private void MinimzedTray()
        {
            notifyIconLS.Visible = true;
            notifyIconLS.Icon = SystemIcons.Application;

            notifyIconLS.BalloonTipText = "Minimized";
            //notifyIcon1.BalloonTipTitle = "Your Application is Running in BackGround";
            notifyIconLS.ShowBalloonTip(500);
        }

        private void MaxmizedFromTray()
        {
            notifyIconLS.Visible = true;
            notifyIconLS.BalloonTipText = "Maximized";
            //notifyIcon1.BalloonTipTitle = "Application is Running in Foreground";
            notifyIconLS.ShowBalloonTip(500);
        }

        private void timerOne_Tick(object sender, EventArgs e)
        {
            var getBoxOne = context.BoxOnes!.Select(w => new { w.Id, w.EnWord, w.BgWord, w.InsertDate, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).FirstOrDefault();

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive }).FirstOrDefault();

            if (timers != null)
            {
                if (getBoxOne != null)//If have words in this table
                {
                    DateTime performanceTime = getBoxOne!.PerformanceTime;

                    if (performanceTime <= DateTime.Now.AddMilliseconds(1))
                    {
                        frmTest.LoadBox("BoxOne");

                        frmTest.Show();
                    }
                }
            }
        }
        private void timerTwo_Tick(object sender, EventArgs e)
        {
            var getBoxTwo = context.BoxTwos!.Select(w => new { w.Id, w.InsertDate, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).FirstOrDefault();

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive }).FirstOrDefault();

            if (timers != null)
            {
                if (getBoxTwo != null)//If have words in this table
                {
                    DateTime performanceTime = getBoxTwo!.PerformanceTime;

                    if (performanceTime <= DateTime.Now.AddMilliseconds(1))
                    {
                        frmTest.LoadBox("BoxTwo");
                        frmTest.Show();
                    }
                }
            }
        }
        private void timerThree_Tick(object sender, EventArgs e)
        {
            var getBoxThree = context.BoxThrees!.Select(w => new { w.Id, w.InsertDate, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).FirstOrDefault();

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive }).FirstOrDefault();

            if (timers != null)
            {
                if (getBoxThree != null)//If have words in this table
                {
                    DateTime performanceTime = getBoxThree!.PerformanceTime;

                    if (performanceTime <= DateTime.Now.AddMilliseconds(1))
                    {
                        frmTest.LoadBox("BoxThree");
                        frmTest.Show();
                    }
                }
            }
        }
        private void timerFour_Tick(object sender, EventArgs e)
        {
            var getBoxFour = context.BoxFours!.Select(w => new { w.Id, w.InsertDate, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).FirstOrDefault();

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive }).FirstOrDefault();

            if (timers != null)
            {
                if (getBoxFour != null)//If have words in this table
                {
                    DateTime performanceTime = getBoxFour!.PerformanceTime;

                    if (performanceTime <= DateTime.Now.AddMilliseconds(1))
                    {
                        frmTest.LoadBox("BoxFour");
                        frmTest.Show();
                    }
                }
            }
        }
        private void timerFive_Tick(object sender, EventArgs e)
        {
            var getBoxFive = context.BoxFives!.Select(w => new { w.Id, w.InsertDate, w.PerformanceTime }).Where(w => w.PerformanceTime <= DateTime.Now).FirstOrDefault();

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive }).FirstOrDefault();

            if (timers != null)
            {
                if (getBoxFive != null)//If have words in this table
                {
                    DateTime performanceTime = getBoxFive!.PerformanceTime;

                    if (performanceTime <= DateTime.Now.AddMilliseconds(1))
                    {
                        frmTest.LoadBox("BoxFive");
                        frmTest.Show();
                    }
                }
            }
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

        private void toolStripButtonTimers_Click(object sender, EventArgs e)
        {
            FrmTimer frmTimers = new FrmTimer();
            frmTimers.Show();
        }

        private void toolStripButtonChart_Click(object sender, EventArgs e)
        {
            FrmCharts frmCharts = new FrmCharts();
            frmCharts.Show();
        }

        private void toolStripButtonWordMovement_Click(object sender, EventArgs e)
        {
            FrmWordMovement frmWordMovement = new FrmWordMovement();
            frmWordMovement.Show();
        }
    }
}



