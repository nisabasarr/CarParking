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
    public partial class DayReport : Form
    {
        public DayReport()
        {
            InitializeComponent();
        }

        private void DayReport_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = "SELECT * FROM Arac WHERE GirisSaati >= DATEADD(DAY, -1, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ReportGrid.DataSource = dt; 
            }

        }
    }
}
