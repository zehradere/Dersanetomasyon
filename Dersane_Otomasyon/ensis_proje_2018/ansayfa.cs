using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensis_proje_2018
{
    public partial class ansayfa : Form
    {
        public ansayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciler frm4 = new ogrenciler();
            frm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ders frm3 = new Frm_ders();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          sinif_islemleri frm4 = new sinif_islemleri();
            frm4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_ogrBilgi frm3 = new Frm_ogrBilgi();
            frm3.Show();
        }

      

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_Bolum frm5 = new Frm_Bolum();
            frm5.Show();
        }

        private void ansayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
