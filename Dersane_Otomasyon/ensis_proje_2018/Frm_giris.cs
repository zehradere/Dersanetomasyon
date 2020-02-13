using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ensis_proje_2018
{
    public partial class Frm_giris : Form
    {
        public Frm_giris()
        {
            InitializeComponent();
        }
        string kadi = "";
        string sifre = "";

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kontroladi = txt_ad.Text;
            string kontrolsifre = txt_sifre.Text;
            OleDbConnection con;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=ensis_proje_2018.accdb");
            con.Open();
            OleDbCommand okuma = new OleDbCommand();
            okuma.Connection = con;
            okuma.CommandText = "SELECT * FROM kullanici_bilgi WHERE k_adi= '" + txt_ad.Text + "'";
            OleDbDataReader reader = okuma.ExecuteReader();
            while (reader.Read())
            {
                kadi = reader["k_adi"].ToString();
                sifre = reader["k_sifre"].ToString();

            }
            con.Close();
            if (kadi == kontroladi && sifre == kontrolsifre)
            {

                ansayfa frm2 = new ansayfa();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİGİLERİNİZİ KONTROL EDİNİZ...");
            }
        }

        private void Frm_giris_Load(object sender, EventArgs e)
        {

        }

        private void lbl_kullanici_ad_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sifre_Click(object sender, EventArgs e)
        {

        }

        private void True(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Frm_giris_KeyDown(object sender, KeyEventArgs e)
        {
          
                
        }

        private void txt_ad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_sifre.Focus();

            }
        }
    }
}
