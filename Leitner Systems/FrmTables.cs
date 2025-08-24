using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataCommon;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Windows.Forms;

namespace Leitner_Systems
{
    public partial class FrmTables : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();
        public FrmTables()
        {
            InitializeComponent();
        }

        //private void buttonRefresh_Click(object sender, EventArgs e)
        //{
        //    SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cnn;

        //    try
        //    {
        //        string tableName = comboBoxTables.Text;

        //        TableResult(tableName, DbConfig.ConnectionString);

        //        CountRows();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        private void TableResult(string tableName, string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {tableName}", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, $"{tableName}");
            dataGridViewTables.DataSource = ds.Tables[$"{tableName}"]?.DefaultView;
        }
        private void CountRows()
        {
            int recordCount = dataGridViewTables.RowCount;

            labelWords.Text = $"Words: {recordCount - 1}"; // -1 because of the header row
        }

        private void dataGridViewEnBgWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string word = textBoxSearch.Text.ToUpper();

            string tableName = comboBoxTables.Text;

            await Execute(tableName, word);
        }
        private async Task Execute(string tableName, string word)
        {

            if (checkBoxEnWord.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {tableName} WHERE EnWord = '{word}'", DbConfig.ConnectionString);
                DataSet ds = new DataSet();
                da.Fill(ds, $"{tableName}");
                dataGridViewTables.DataSource = ds.Tables[$"{tableName}"]?.DefaultView;

                CountRows();
            }
            else if (checkBoxBgWord.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {tableName} WHERE BgWord = N'{word}'", DbConfig.ConnectionString);
                DataSet ds = new DataSet();
                da.Fill(ds, $"{tableName}");
                dataGridViewTables.DataSource = ds.Tables[$"{tableName}"]?.DefaultView;


                CountRows();
            }
            else
            {
                MessageBox.Show("Choice a checkbox!");
            }
        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            string tableName = comboBoxTables.Text;

            Update(tableName);
        }

        private void Update(string tableName)
        {
            string connectionString = null;
            string? columnName = null;

            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewTables.CurrentRow.Index;
            int colindex = dataGridViewTables.CurrentCell.ColumnIndex;

            columnName = dataGridViewTables.Columns[colindex].HeaderText;

            string? getValue = dataGridViewTables.CurrentCell.Value.ToString();
            string? id = dataGridViewTables.Rows[rowindex].Cells[0].Value.ToString();

            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update {tableName} set {columnName}=@{columnName} Where Id={id}";
                    cmd = new SqlCommand(sqlCommand, cnn);

                    if (colindex == 3 || colindex == 4)
                    {
                        cmd.Parameters.AddWithValue($"@{columnName}", DateTime.Parse(getValue!));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue($"@{columnName}", getValue);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            FrmInsert insert = new FrmInsert();
            insert.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                    "Наистина ли искате да изтриете този ред?", // Текст на съобщението
                                    "Потвърждение за изтриване", // Заглавие на прозореца
                    MessageBoxButtons.YesNo, // Бутони: Да и Не
                MessageBoxIcon.Question); // Икона: Въпрос

            if (result == DialogResult.Yes)
            {
                string tableName = comboBoxTables.Text;

                Delete(tableName);
            }
        }

        private void Delete(string tableName)
        {
            DataGridViewCell cell = dataGridViewTables.SelectedCells[0] as DataGridViewCell;
            string value = cell.Value.ToString()!;
            int getID = int.Parse(value);

            //Remove row from DataGridView
            int rowIndex = dataGridViewTables.CurrentCell.RowIndex;
            this.dataGridViewTables.Rows.RemoveAt(rowIndex);

            //String Connection
            string connetionString = string.Empty;
            connetionString = DbConfig.ConnectionString;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            //Delete from DB
            cmd.CommandText = ($"Delete From {tableName} Where Id = " + getID + "");

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The row has been deleted ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }
        }

        private void checkBoxEnWord_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBgWord.Checked = false;
        }

        private void checkBoxBgWord_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEnWord.Checked = false;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            string tableName = comboBoxTables.Text;

            if (!tableName.IsNullOrEmpty())
            {
                TableResult(tableName, DbConfig.ConnectionString);

                CountRows();
            }

            //if (tableName == "BoxOnes" || tableName == "EnBgWords")
            //{
            //    buttonDelete.Enabled = true;
            //}
            //else
            //{
            //    buttonDelete.Enabled = false;
            //}
        }
    }
}
