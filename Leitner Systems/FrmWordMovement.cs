using Leitner_Systems.LeitnerSystemsDataCommon;
using Microsoft.Data.SqlClient;
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
    public partial class FrmWordMovement : Form
    {
        public FrmWordMovement()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            TableWordMovement();
            CountRows();
        }
        private void TableWordMovement()
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM WordMovements", DbConfig.ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, $"WordMovements");
            dataGridViewWordMovement.DataSource = ds.Tables[$"WordMovements"]?.DefaultView;
        }
        private void CountRows()
        {
            int recordCount = dataGridViewWordMovement.RowCount;

            labelLines.Text = $"Words: {recordCount - 1}"; // -1 because of the header row
        }
    }
}
