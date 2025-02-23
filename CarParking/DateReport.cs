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

namespace CarParking
{
    public partial class DateReport : Form
    {
        public DateReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1);

            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = "SELECT * FROM Arac WHERE GirisSaati BETWEEN @BaslangicTarihi AND @BitisTarihi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                RaporGrid.DataSource = dt; // DataGridView'e veriyi bağla
            }

        }
    }
}
