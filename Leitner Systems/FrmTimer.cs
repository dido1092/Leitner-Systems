using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataCommon;
using Leitner_Systems.LeitnerSystemsDataModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Leitner_Systems
{
    public partial class FrmTimer : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        public FrmTimer()
        {
            InitializeComponent();
        }

        private void comboBoxTwo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmTimers_Load(object sender, EventArgs e)
        {
            UpdateTimer();

        }

        private void UpdateTimer()
        {
            //string? mhd = string.Empty;

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive, t.MHD }).FirstOrDefault();

            if (timers != null)
            {
                //mhd = Timers();

                comboBoxMHD.Text = timers.MHD;

                labelInfo.Text = $"BoxOne: '{timers!.BoxOne}' / BoxTwo: '{timers!.BoxTwo}' / BoxThree: '{timers!.BoxThree}' / BoxFour: '{timers!.BoxFour}' / BoxFive: '{timers!.BoxFive}' In: {timers.MHD}";
            }
        }

        public string Timers()
        {
            string mhd = string.Empty;

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive, t.MHD }).FirstOrDefault();

            if (timers != null)
            {
                if (timers.MHD == "Mins")
                {
                    mhd = "Mins";
                }
                else if (timers.MHD == "Hours")
                {
                    mhd = "Hours";
                }
                else if (timers.MHD == "Days")
                {
                    mhd = "Days";
                }
            }

            return mhd;
        }

        private async void buttonSet_Click(object sender, EventArgs e)
        {
            var checkValue = context.Timers!.Select(t => t.MHD).FirstOrDefault();//Check if there is any existing timer record

            string boxOne = comboBoxOne.Text;
            string boxTwo = comboBoxTwo.Text;
            string boxThree = comboBoxThree.Text;
            string boxFour = comboBoxFour.Text;
            string boxFive = comboBoxFive.Text;
            string mhd = comboBoxMHD.Text;

            if (boxOne != string.Empty && boxTwo != string.Empty && boxThree != string.Empty && boxFour != string.Empty && boxFive != string.Empty && mhd != string.Empty)
            {
                if (checkValue != null)
                {
                    UpdateAll(boxOne, boxTwo, boxThree, boxFour, boxFive, mhd);
                }
                else//New record
                {
                    await TruncateTableTimersAsync();

                    context.SaveChanges();

                    Tmr tmr = new Tmr()
                    {
                        BoxOne = comboBoxOne.Text,
                        BoxTwo = comboBoxTwo.Text,
                        BoxThree = comboBoxThree.Text,
                        BoxFour = comboBoxFour.Text,
                        BoxFive = comboBoxFive.Text,
                        MHD = comboBoxMHD.Text
                    };
                    context.Timers!.Add(tmr);

                    context.SaveChanges();
                }
            }
            if (boxOne != string.Empty)
            {
                UpdateAny("BoxOne", boxOne);
            }
            if (boxTwo != string.Empty)
            {
                UpdateAny("BoxTwo", boxTwo);
            }
            if (boxThree != string.Empty)
            {
                UpdateAny("BoxThree", boxThree);
            }
            if (boxFour != string.Empty)
            {
                UpdateAny("BoxFour", boxFour);
            }
            if (boxFive != string.Empty)
            {
                UpdateAny("BoxFive", boxFive);
            }
            if (mhd != string.Empty)
            {
                UpdateAny("MHD", mhd);
            }
            if (boxOne == string.Empty && boxTwo == string.Empty && boxThree == string.Empty && boxFour == string.Empty && boxFive == string.Empty && mhd == string.Empty)
            {
                return;
            }

            UpdateTimer();

            MessageBox.Show("Done!");
        }
        public async Task TruncateTableTimersAsync()
        {
            await context.Database.ExecuteSqlRawAsync("TRUNCATE TABLE Timers");
        }
        private void UpdateAll(string boxOne, string boxTwo, string boxThree, string boxFour, string boxFive, string mhd)
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                using (cnn = new SqlConnection(DbConfig.ConnectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update Timers set BoxOne=@BoxOne, BoxTwo=@BoxTwo, BoxThree=@BoxThree, BoxFour=@BoxFour, BoxFive=@BoxFive, MHD=@MHD";
                    cmd = new SqlCommand(sqlCommand, cnn);

                    cmd.Parameters.AddWithValue($"@BoxOne", boxOne);
                    cmd.Parameters.AddWithValue($"@BoxTwo", boxTwo);
                    cmd.Parameters.AddWithValue($"@BoxThree", boxThree);
                    cmd.Parameters.AddWithValue($"@BoxFour", boxFour);
                    cmd.Parameters.AddWithValue($"@BoxFive", boxFive);
                    cmd.Parameters.AddWithValue($"@MHD", mhd);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    //if (rowsAffected == 1)
                    //{
                    //    MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateAny(string comboBox, string value)
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                using (cnn = new SqlConnection(DbConfig.ConnectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update Timers set {comboBox}=@{comboBox}";
                    cmd = new SqlCommand(sqlCommand, cnn);

                    cmd.Parameters.AddWithValue($"@{comboBox}", value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    //if (rowsAffected == 1)
                    //{
                    //    MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive, t.MHD }).FirstOrDefault();

            if (timers != null)
            {
                comboBoxOne.Text = timers!.BoxOne;
                comboBoxTwo.Text = timers.BoxTwo;
                comboBoxThree.Text = timers.BoxThree;
                comboBoxFour.Text = timers.BoxFour;
                comboBoxFive.Text = timers.BoxFive;
                comboBoxMHD.Text = timers.MHD;
            }
        }
    }
}
