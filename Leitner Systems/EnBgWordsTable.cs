using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataCommon;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Leitner_Systems
{
    public partial class EnBgWordsTable : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();
        public EnBgWordsTable()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                TableResult(DbConfig.ConnectionString);

                string query = "SELECT COUNT(*) FROM [EnBgWords]";

                CountRows(query, DbConfig.ConnectionString);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void TableResult(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EnBgWords", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "EnBgWords");
            dataGridViewEnBgWords.DataSource = ds.Tables["EnBgWords"]?.DefaultView;
        }
        private void CountRows(string query, string connectionString)
        {
            // Create the connection.
            SqlConnection conn = new SqlConnection(DbConfig.ConnectionString);

            // Build the query to count, including CustomerID criteria if specified.
            string selectText = query;

            // Create the command to count the records.
            SqlCommand cmd = new SqlCommand(selectText, conn);

            // Execute the command, storing the results.
            conn.Open();
            int recordCount = (int)cmd.ExecuteScalar();
            conn.Close();
            //labelEventNums.Text = $"Събития бр: {recordCount}";
            labelWords.Text = $"Words: {recordCount}";
        }

        private void dataGridViewEnBgWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string word = textBoxSearch.Text.ToUpper();

            await Execute(word);
        }
        private async Task Execute(string word)
        {

            if (checkBoxEnWord.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM EnBgWords WHERE EnWord = '{word}'", DbConfig.ConnectionString);
                DataSet ds = new DataSet();
                da.Fill(ds, "EnBgWords");
                dataGridViewEnBgWords.DataSource = ds.Tables["EnBgWords"]?.DefaultView;

                string query = $"SELECT * FROM EnBgWords WHERE EnWord = '{word}'";

                CountRows(query, DbConfig.ConnectionString);
            }
            else if (checkBoxBgWord.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM EnBgWords WHERE BgWord = N'{word}'", DbConfig.ConnectionString);
                DataSet ds = new DataSet();
                da.Fill(ds, "EnBgWords");
                dataGridViewEnBgWords.DataSource = ds.Tables["EnBgWords"]?.DefaultView;

                string query = $"SELECT * FROM EnBgWords WHERE BgWord = '{word}'";

                CountRows(query, DbConfig.ConnectionString);
            }
            else
            {
                MessageBox.Show("Choice a checkbox!");
            }
        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewEnBgWords.CurrentRow.Index;
            int colindex = dataGridViewEnBgWords.CurrentCell.ColumnIndex;

            string? columnName = dataGridViewEnBgWords.Columns[colindex].HeaderText;

            string? getValue = dataGridViewEnBgWords.CurrentCell.Value.ToString();
            string? id = dataGridViewEnBgWords.Rows[rowindex].Cells[0].Value.ToString();

            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update EnBgWords set {columnName}=@{columnName} Where Id={id}";
                    cmd = new SqlCommand(sqlCommand, cnn);
                    cmd.Parameters.AddWithValue($"@{columnName}", getValue);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                    "Наистина ли искате да изтриете този ред?", // Текст на съобщението
                                    "Потвърждение за изтриване", // Заглавие на прозореца
                    MessageBoxButtons.YesNo, // Бутони: Да и Не
                MessageBoxIcon.Question); // Икона: Въпрос

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(PerformDeletion());

                MessageBox.Show($"The row with id: {id} has been deleted!");
            }

            PerformDeletion();
        }

        private string PerformDeletion()
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewEnBgWords.CurrentRow.Index;
            int colindex = dataGridViewEnBgWords.CurrentCell.ColumnIndex;

            string? columnName = dataGridViewEnBgWords.Columns[colindex].HeaderText;

            string? getValue = dataGridViewEnBgWords.CurrentCell.Value.ToString();
            string? id = dataGridViewEnBgWords.Rows[rowindex].Cells[0].Value.ToString();

            var rowsAffected = context.EnBgWords!.Where(p => p.Id == int.Parse(id!)).ExecuteDeleteAsync();

            return id;
        }

        private void checkBoxEnWord_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBgWord.Checked = false;
        }

        private void checkBoxBgWord_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEnWord.Checked = false;
        }
    }
}
