using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int sayacBeyaz = 10;
        int sayacSiyah = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
             timer1.Start();
            this.BackColor = Color.White;
        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            timer2.Start();
        }

        private void btnSıyah_Click(object sender, EventArgs e)
        {
            timer2.Stop();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayacBeyaz--;
            lblBeyaz.Text = sayacBeyaz.ToString();

            if (sayacBeyaz <= 0)
            {
                timer1.Stop();

                lblMesaj.Text = "SİYAH KAZANDI";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayacSiyah--;
            lblSiyah.Text = sayacSiyah.ToString();

            if (sayacSiyah <= 0)
            {
                timer2.Stop();

                lblMesaj.Text = "BEYAZ KAZANDI";
            }
        }
    }
}