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
    public partial class CarLogin : Form
    {
        public CarLogin()
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
                string query = "INSERT INTO Arac (Plaka, GirisSaati) VALUES (@Plaka, @GirisSaati)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Plaka", plaka);
                cmd.Parameters.AddWithValue("@GirisSaati", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Araç giriş yaptı!");
        }
    }
}
