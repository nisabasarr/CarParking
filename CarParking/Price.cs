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
    public partial class Price : Form
    {
        public Price()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Fiyat = (int)numFiyat.Value;

            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = "UPDATE Ayarlar SET SaatlikUcret = @Fiyat";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fiyat", Fiyat);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Otopark saatlik ücreti güncellendi!");
        }

        private void Price_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = "SELECT TOP 1 SaatlikUcret FROM Ayarlar";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                object result = cmd.ExecuteScalar(); 
                conn.Close();

                if (result != null)
                {
                    numFiyat.Value = (decimal)result; 
                }
                
            }
        }
    }
}
