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
    public partial class Capasite : Form
    {
        public Capasite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kapasite = (int)numKapasite.Value;

            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = "UPDATE Ayarlar SET OtoparkKapasitesi = @Kapasite";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Kapasite", kapasite);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Otopark kapasitesi güncellendi!");

        }

        private void Capasite_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlHelper.GetConnection())
            {
                string query = "SELECT TOP 1 OtoparkKapasitesi FROM Ayarlar";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    numKapasite.Value = (int)result;
                }

            }
        }
    }
}
