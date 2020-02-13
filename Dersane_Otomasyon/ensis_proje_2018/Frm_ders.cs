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
    public partial class Frm_ders : Form
    {
        public Frm_ders()
        {
            InitializeComponent();
        }
        public DataTable tablo = new DataTable();
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ensis_proje_2018.accdb");
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand kmt = new OleDbCommand();
        void listele()
        {
            txt_ders_adi.Text = "";
            txt_ders_kodu.Text= "";
            cbox_dersgunu.Text = "";
            maskedTextBox_dersssati.Text = "";
            cbox_sube.Text = "";

            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From dersler", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
        }

        private void cbox_sube_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ders_Load(object sender, EventArgs e)
        {
            listele();
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select  * from dersler", bag);
            
            OleDbDataReader drrr = kmt.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (drrr.Read())
            {
                mycollection.Add(drrr["ders_kodu"].ToString());
                

            }
            txt_derskod_arama.AutoCompleteCustomSource = mycollection;
            bag.Close();
            listele();

            bag.Open();
            kmt = new OleDbCommand("Select * from siniflar", bag);
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cbox_sube.Items.Add(dr["sinif_sube"].ToString());
            }
            bag.Close();
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "INSERT INTO dersler (ders_adi,ders_kodu,ders_gunu,ders_saati,sinif_sube) VALUES ('" + txt_ders_adi.Text + "','" + txt_ders_kodu.Text +  "','"+cbox_dersgunu.Text+"','"+maskedTextBox_dersssati.Text+"','"+cbox_sube.Text+"') ";
            kmt.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kayıt Başarılı");
            listele();
           

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

            string sorgu = "UPDATE dersler SET ders_adi='" + txt_ders_adi.Text + "' , ders_kodu='" + txt_ders_kodu.Text + "', ders_gunu='" + cbox_dersgunu.Text + "',ders_saati='" + maskedTextBox_dersssati.Text + "',sinif_sube='" + cbox_sube.Text + "'  where ders_no = " + idi +"";

            OleDbCommand kmt = new OleDbCommand(sorgu, bag);

            bag.Open();
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            bag.Close();
            MessageBox.Show("işleminiz başarılı");
            listele();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM dersler WHERE ders_kodu=@derskodu ", bag);
            adtr.SelectCommand.Parameters.AddWithValue("@derskodu",txt_derskod_arama.Text);
            
            DataTable tablo = new DataTable();
            bag.Open();
            adtr.Fill(tablo);
            bag.Close();

            if (tablo != null && tablo.Rows.Count > 0)
                dataGridView1.DataSource = tablo;
            else MessageBox.Show("LÜTFEN BİLGİLERİNİZ KONTROL EDİNİZ");
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           txt_ders_adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ders_kodu.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbox_dersgunu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox_dersssati.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbox_sube.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           

            bag.Open();
            int id = 0;
            if (!string.IsNullOrEmpty(lblid.Text))
            {
                id = Convert.ToInt32(lblid.Text);
            }
            else
            {
                id = 0;
            }
            kmt.Connection = bag;
            kmt.CommandText = "DELETE from dersler WHERE ders_no= " + id +"";
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            bag.Close();
            MessageBox.Show("Silme İşlemi Başarılı..");
            listele();
        }

        private void txt_ders_kodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
             listele();
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("select  * from dersler", bag);
            
            OleDbDataReader drrr = kmt.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (drrr.Read())
            {
                mycollection.Add(drrr["ders_kodu"].ToString());
                

            }
            txt_derskod_arama.AutoCompleteCustomSource = mycollection;
            bag.Close();
            listele();

            bag.Open();
            kmt = new OleDbCommand("Select * from siniflar", bag);
            OleDbDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cbox_sube.Items.Add(dr["sinif_sube"].ToString());
            }
            bag.Close();
           
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
    
        
        }
    }
