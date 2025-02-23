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
    public partial class Rate : Form
    {
        public Rate()
        {
            InitializeComponent();
        }

        private void Rate_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = @"
            SELECT (COUNT(*) * 100.0 / (SELECT OtoparkKapasitesi FROM Ayarlar)) AS DolulukOrani
            FROM Arac WHERE CikisSaati IS NULL";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    double dolulukOrani = Convert.ToDouble(result);
                    Ratelbl.Text = $"Doluluk Oranı: %{dolulukOrani:F2}";
                }
                else
                {
                    Ratelbl.Text = "Doluluk oranı hesaplanamadı.";
                }
            }

        }
    }
}
