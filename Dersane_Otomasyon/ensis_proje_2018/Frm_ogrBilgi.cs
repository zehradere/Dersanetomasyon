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
    public partial class Frm_ogrBilgi : Form
    {
        public Frm_ogrBilgi()
        {
            InitializeComponent();
        }
        public DataTable tablo = new DataTable();
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ensis_proje_2018.accdb");
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand kmt = new OleDbCommand();
     
        void listele()
        {
            cbox_ogrno.Text = "";
            cbox_ad.Text = "";
            cbox_soyad.Text = "";
            cbox_bolum.Text = "";
            cbox_sube.Text = "";

            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select  ogrenci_no,adi,soyadi,bolum_adi,sinif_sube  From ders_saatleri", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "INSERT INTO ders_saatleri (ogrenci_no,adi,soyadi,bolum_adi,sinif_sube) VALUES ('" + cbox_ogrno.Text + "','" + cbox_ad.Text + "','" + cbox_soyad.Text + "','"+cbox_bolum.Text+"','"+cbox_sube.Text+"')";
            kmt.ExecuteNonQuery();
            bag.Close();
            listele();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void cbox_ogrno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Frm_ogrBilgi_Load(object sender, EventArgs e)
        {
            listele();
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select * from ders_saatleri", bag);
           
            OleDbDataReader drrr = kmt.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (drrr.Read())
            {
                mycollection.Add(drrr["sinif_sube"].ToString());
                mycollection.Add(drrr["bolum_adi"].ToString());


            }
            textBox3.AutoCompleteCustomSource = mycollection;
            textBox1_ogr_sinif_arama.AutoCompleteCustomSource=mycollection;
            bag.Close();
            listele();
            bag.Open();
            OleDbCommand kmtt = new OleDbCommand("Select * from ogrenciler", bag);
            OleDbDataReader drr = kmtt.ExecuteReader();
            while (drr.Read())
            {

                cbox_ogrno.Items.Add(drr["ogrenci_no"].ToString());
                cbox_ad.Items.Add(drr["adi"].ToString());
                cbox_soyad.Items.Add(drr["soyadi"].ToString());

            }


           
            bag.Close();
            listele();
            bag.Open();
            OleDbCommand kmttt = new OleDbCommand("Select * from bolumler", bag);
            OleDbDataReader drrrr = kmttt.ExecuteReader();
            while (drrrr.Read())
            {

                cbox_bolum.Items.Add(drrrr["bolum_adi"].ToString());            

            }


            bag.Close();
            listele();
            bag.Open();
            OleDbCommand kmttttt = new OleDbCommand("Select * from siniflar ", bag);
            OleDbDataReader drrrrr = kmttttt.ExecuteReader();
            while (drrrrr.Read())
            {

                cbox_sube.Items.Add(drrrrr["sinif_sube"].ToString());              

            }

            bag.Close();       
         
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int idi = 0;
            if (!string.IsNullOrEmpty(lblid.Text))
            {
                idi = Convert.ToInt32(lblid.Text);
            }
            else
            {
                idi = 0;
            }

            string sorgu = "UPDATE ders_saatleri SET ogrenci_no='" + cbox_ogrno.Text + "',adi='" + cbox_ad.Text + "',soyadi ='" + cbox_soyad.Text + "',bolum_adi ='" + cbox_bolum.Text + "',sinif_sube ='" + cbox_sube.Text + "'where ogrenci_no = '"  + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            OleDbCommand kmt = new OleDbCommand(sorgu, bag);
            bag.Open();

            kmt.ExecuteNonQuery();
            kmt.Dispose();

            bag.Close();
            MessageBox.Show("işleminiz başarılı");
            listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT ogrenci_no,adi,soyadi,bolum_adi,sinif_sube   FROM ders_saatleri WHERE bolum_adi=@bolumad AND sinif_sube =@sinifsube ", bag);
            adtr.SelectCommand.Parameters.AddWithValue("@bolumad", textBox3.Text);
            adtr.SelectCommand.Parameters.AddWithValue("@sinifsube", textBox1_ogr_sinif_arama.Text);

            DataTable tablo = new DataTable();
            bag.Open();
            adtr.Fill(tablo);
            bag.Close();

            if (tablo != null && tablo.Rows.Count > 0)
                dataGridView1.DataSource = tablo;
            else MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           cbox_ogrno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           cbox_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           cbox_soyad.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
           cbox_bolum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           cbox_sube.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            bag.Open();
            
            kmt.Connection = bag;
            kmt.CommandText = "DELETE from ders_saatleri WHERE ogrenci_no='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            bag.Close();
            MessageBox.Show("Silme İşlemi Başarılı..");
            listele();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbox_ogrno_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            listele();
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select * from ders_saatleri", bag);

            OleDbDataReader drrr = kmt.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (drrr.Read())
            {
                mycollection.Add(drrr["sinif_sube"].ToString());
                mycollection.Add(drrr["bolum_adi"].ToString());


            }
            textBox3.AutoCompleteCustomSource = mycollection;
            textBox1_ogr_sinif_arama.AutoCompleteCustomSource = mycollection;
            bag.Close();
            listele();
            bag.Open();
            OleDbCommand kmtt = new OleDbCommand("Select * from ogrenciler", bag);
            OleDbDataReader drr = kmtt.ExecuteReader();
            while (drr.Read())
            {

                cbox_ogrno.Items.Add(drr["ogrenci_no"].ToString());
                cbox_ad.Items.Add(drr["adi"].ToString());
                cbox_soyad.Items.Add(drr["soyadi"].ToString());

            }

            bag.Close();
            listele();
            bag.Open();
            OleDbCommand kmttt = new OleDbCommand("Select * from bolumler", bag);
            OleDbDataReader drrrr = kmttt.ExecuteReader();
            while (drrrr.Read())
            {

                cbox_bolum.Items.Add(drrrr["bolum_adi"].ToString());


            }

            bag.Close();
            listele();
            bag.Open();
            OleDbCommand kmttttt = new OleDbCommand("Select * from siniflar ", bag);
            OleDbDataReader drrrrr = kmttttt.ExecuteReader();
            while (drrrrr.Read())
            {

                cbox_sube.Items.Add(drrrrr["sinif_sube"].ToString());

            }

            bag.Close();
            listele();
        }


        private void btn_excell_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myrange.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myrange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j+2, i + 1];
                    myrange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }


        private void textBox1_ogr_sinif_arama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbox_sayad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        
        }
    }

