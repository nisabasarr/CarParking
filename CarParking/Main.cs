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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarLogin CarLogin = new CarLogin();
            CarLogin.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            CarLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarExit CarExit = new CarExit();
            CarExit.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            CarExit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Capasite Capasite = new Capasite();
            Capasite.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            Capasite.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateReport DateReport = new DateReport();
            DateReport.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            DateReport.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DayReport DayReport = new DayReport();
            DayReport.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            DayReport.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rate Rate = new Rate();
            Rate.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            Rate.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Price Price = new Price();
            Price.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            Price.Show();
        }
    }
}
