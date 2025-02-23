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
    public partial class CarExit : Form
    {
        public CarExit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text.Trim();
            if (string.IsNullOrEmpty(plaka))
            {
                MessageBox.Show("Plaka giriniz!");
                return;
            }

            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string selectQuery = "SELECT TOP 1 AracID, GirisSaati FROM Arac WHERE Plaka = @Plaka AND CikisSaati IS NULL";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                selectCmd.Parameters.AddWithValue("@Plaka", plaka);

                conn.Open();
                SqlDataReader reader = selectCmd.ExecuteReader();
                if (reader.Read())
                {
                    int aracID = reader.GetInt32(0);
                    DateTime girisSaati = reader.GetDateTime(1);
                    reader.Close();

                    TimeSpan parkSure = DateTime.Now - girisSaati;
                    decimal saatlikUcret = GetSaatlikUcret();
                    decimal toplamUcret = (decimal)parkSure.TotalHours * saatlikUcret;

                    string updateQuery = "UPDATE Arac SET CikisSaati = @CikisSaati, Ucret = @Ucret WHERE AracID = @AracID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@CikisSaati", DateTime.Now);
                    updateCmd.Parameters.AddWithValue("@Ucret", toplamUcret);
                    updateCmd.Parameters.AddWithValue("@AracID", aracID);

                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show($"Araç çıkışı yapıldı. Toplam Ücret: {toplamUcret:C}");
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı!");
                }

                conn.Close();
            }

        }

        private decimal GetSaatlikUcret()
        {
            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = "SELECT SaatlikUcret FROM Ayarlar";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                decimal ucret = (decimal)cmd.ExecuteScalar();
                conn.Close();

                return ucret;
            }
        }

    }
}
